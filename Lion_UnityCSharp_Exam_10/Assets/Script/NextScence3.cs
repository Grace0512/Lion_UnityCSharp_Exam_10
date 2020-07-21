using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScence3 : MonoBehaviour
{
    

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("第2題");
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("第4題");
        }

    }
}
