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
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(GetComponent<Rigidbody>().velocity/110, ForceMode.Impulse);
    }

}
