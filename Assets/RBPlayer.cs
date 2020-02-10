using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBPlayer : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float forwardinput = Input.GetAxis("Vertical");
        rb.AddRelativeForce(Vector3.forward * Time.deltaTime * forwardinput, ForceMode.Acceleration);
    }
}
