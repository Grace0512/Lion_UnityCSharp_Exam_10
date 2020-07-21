using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Q5_Poker : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();

    private string[] type = { "Spades", "Diamond", "Heart", "Club" };

    void Start()
    {
        GetAllCard();
        SortCard();
    }

    private void SortCard()
    {
        var sort = from card in cards
                   where card.name.Contains(type[3]) || card.name.Contains(type[2]) || card.name.Contains(type[1]) || card.name.Contains(type[0])
                   select card;
        
        foreach (var item in sort) Instantiate(item, transform);
        StartCoroutine(CardPosition());
    }

    private void GetAllCard()
    {
        for (int i = 0; i < type.Length; i++)
        {
            if (cards.Count == 52) return;

            for (int j = 1; j < 14; j++)
            {
                string number = j.ToString();

                switch (j)
                {
                    case 1:
                        number = "A";
                        break;
                    case 11:
                        number = "J";
                        break;
                    case 12:
                        number = "Q";
                        break;
                    case 13:
                        number = "K";
                        break;

                }


                GameObject card = Resources.Load<GameObject>("PlayingCards_" + number + type[i]);
                cards.Add(card);
            }
        }
    }

    private IEnumerator CardPosition()
    {

        yield return new WaitForSeconds(0.1f);
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.eulerAngles = new Vector3(180, 0, 0);
            child.localScale = Vector3.one * 20;
            print(child.childCount);

            

            float x = i % (transform.childCount/4);
            float y = i / (transform.childCount / 4);
            child.position = new Vector3((x - 6) * 1.3f, 4 - y * 2, 0);

            yield return null;
        }

    }

    public void DeleteEven()
    {
        DeleteAllChild();

        List<GameObject> newCards = new List<GameObject>();

        var even = from odd in cards
                   where odd.name.Contains("A") || odd.name.Contains("3") || odd.name.Contains("5") || odd.name.Contains("7") || odd.name.Contains("9") || odd.name.Contains("J")|| odd.name.Contains("K")
                   select odd;
        
        foreach (var item in even) Instantiate(item, transform);

            StartCoroutine(CardPosition());

    }
    private void DeleteAllChild()
    {
        for (int i = 0; i < transform.childCount; i++) Destroy(transform.GetChild(i).gameObject);
    }
}
