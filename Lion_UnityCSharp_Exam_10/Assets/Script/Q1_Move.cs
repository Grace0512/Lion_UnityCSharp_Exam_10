using UnityEngine;

public class Q1_Move : MonoBehaviour
{

     
    void Update()
    {
        if(transform.position.z<3)
        transform.Translate(0, 0, 3 * Time.deltaTime);
    }
}
