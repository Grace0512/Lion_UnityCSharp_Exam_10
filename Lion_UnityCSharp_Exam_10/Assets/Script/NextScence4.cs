using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScence4 : MonoBehaviour
{
    

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("第3題");
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("第5題");
        }

    }
}
