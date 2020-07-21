using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Q4_Runner player;
    public GameObject end;

    private void Start()
    {
        end.SetActive(false);
        player.GetEnd += EndCanvas;
    }

    public void EndCanvas()
    {
        end.SetActive(true);

    }
}