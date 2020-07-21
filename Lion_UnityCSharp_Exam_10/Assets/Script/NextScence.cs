using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScence : MonoBehaviour
{
    

   
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("第1題");
        }

    }
}
