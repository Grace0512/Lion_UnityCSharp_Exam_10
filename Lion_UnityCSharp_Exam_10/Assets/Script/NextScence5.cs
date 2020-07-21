using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScence5 : MonoBehaviour
{
    

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("第4題");
        }
        

    }
}
