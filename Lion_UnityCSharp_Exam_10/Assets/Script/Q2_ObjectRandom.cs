using UnityEngine;
using UnityEngine.UI;

public class Q2_ObjectRandom : MonoBehaviour
{
    [Header("放物件圖片")]
    public Sprite[] prop;

    [Header("得到的物品")]
    public Image GetProp;

    //按下按鍵的時間
    private float ButtonTime;
    void Start()
    {
        ButtonTime = Time.time - 1.5f;
    }

    
    void Update()
    {
      if(Time.time-ButtonTime<1.5f)
        {
            ChangeSprite();
        }

    }

    public void ChangeTime()
    {
        ButtonTime = Time.time;
    }


    public void ChangeSprite()
    {
        int Ran = Random.Range(0, prop.Length);
        GetProp.sprite = prop[Ran];
    }
}
