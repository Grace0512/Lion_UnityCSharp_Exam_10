using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScence1 : MonoBehaviour
{
    

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Meau");
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("第2題");
        }

    }
}
