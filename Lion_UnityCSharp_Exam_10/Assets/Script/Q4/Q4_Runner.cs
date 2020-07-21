using UnityEngine;

public class Q4_Runner : MonoBehaviour
{
    private Rigidbody rig;
    private Animator ani;
    private Vector3 angle;

    public delegate void PlayerEvent();

    public event PlayerEvent GetEnd;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
        GetEnd += Move;

    }

    private void FixedUpdate()
    {
        Move();

    }

    private void Move()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        rig.AddForce(transform.forward * 10 * Mathf.Abs(v));
        rig.AddForce(transform.forward * 10 * Mathf.Abs(h));

        ani.SetBool("跑步", Mathf.Abs(v) > 0 || Mathf.Abs(h) > 0);
        if (v == 1) angle = new Vector3(0, 0, 0); // 前 y=0
        else if (v == -1) angle = new Vector3(0, 180, 0); //後 y=180
        else if (h == 1) angle = new Vector3(0, 90, 0); //右 y=90
        else if (h == -1) angle = new Vector3(0, 270, 0); //左 y=270
        transform.eulerAngles = angle;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "End") GetEnd();

    }
}
