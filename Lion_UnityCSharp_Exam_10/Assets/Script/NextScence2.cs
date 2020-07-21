using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScence2 : MonoBehaviour
{
    

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("第1題");
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("第3題");
        }

    }
}
