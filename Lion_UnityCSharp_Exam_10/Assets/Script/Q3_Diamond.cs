using UnityEngine;

public class Q3_Diamond : MonoBehaviour
{
    public GameObject diamond;

    private float x = 0;
    private float z = 7;

    private void Start()
    {
        PrintDiamomd();
    }

    public void PrintDiamomd()
    {
        for(float i = 0; i < 7; i++)
        {
            for(float j=0;j<i;j++)
            {
               Instantiate(diamond,new Vector3(x, 0.5f, z), Quaternion.identity);
                x++;
            }
            z--;
           
                x = -0.5f * i;
            
        }
        for(float i = 5; i > 0; i--)
        {
            for(float j=i;j>0;j--)
            { 
                x++;
                Instantiate(diamond, new Vector3(x, 0.5f, z), Quaternion.identity);
               
            }
            x = -0.5f * i;
            z--;
        }
        
    }
}
