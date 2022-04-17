using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_force_ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(Vector3.down*15, ForceMode.Impulse);
        rigidbody.AddForce(Vector3.right, ForceMode.Impulse); 
    }

    // Update is called once per frame
    void Update()
    {
    }
    int golden = 0;
    int ruby = 0;
    public int number_of_blocks = 21;
    public static void F_golden(int golden)
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(GetComponent<Rigidbody>().velocity/110, ForceMode.Impulse);
        if (collision.collider.tag == "golden")
        {
            if (collision.contactCount == 1)
            {
                golden++;
                if (golden == 3)
                {
                    Destroy(collision.gameObject);
                    number_of_blocks--;
                }
            }
        }
        if (collision.collider.tag == "ruby")
        {
            if (collision.contactCount == 1)
            {
                ruby++;
                if (ruby == 5)
                {
                    Destroy(collision.gameObject);
                    number_of_blocks--;
                }
            }
        }
        if (collision.collider.tag == "block")
        {
            Destroy(collision.gameObject);
            number_of_blocks--;
        }
    }

    

}
