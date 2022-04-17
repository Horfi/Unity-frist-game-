using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_block : MonoBehaviour
{
    private float horizontalImput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalImput = Input.GetAxis("Horizontal");
    }
    
    // every physics update

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3 (horizontalImput*16, 0, 0);
    }
}
