using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Car;
    public float Speed;
    public float CameraSense;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
            Car.transform.Translate(0, 0, 0.1f * Speed);
        if (Input.GetKey("s"))
            Car.transform.Translate(0, 0, -0.025f * Speed);
        if (Input.GetKey("a") && !Input.GetKey("w") && !Input.GetKey("s"))
        {
            Car.transform.Translate(0, 0, 0.025f * Speed);
            Car.transform.Rotate(0, -0.5f * CameraSense, 0, Space.Self);
        }

        if (Input.GetKey("d") && !Input.GetKey("w") && !Input.GetKey("s"))
        {
            Car.transform.Translate(0, 0, 0.025f * Speed);
            Car.transform.Rotate(0, 0.5f * CameraSense, 0, Space.Self);
        }

        if (Input.GetKey("d") && Input.GetKey("s"))
            Car.transform.Rotate(0, -1 * CameraSense, 0, Space.Self);
        if (Input.GetKey("a") && Input.GetKey("s"))
            Car.transform.Rotate(0, 1 * CameraSense, 0, Space.Self);
        if (Input.GetKey("d") && Input.GetKey("w"))
            Car.transform.Rotate(0, 1 * CameraSense, 0, Space.Self);
        if (Input.GetKey("a") && Input.GetKey("w"))
            Car.transform.Rotate(0, -1 * CameraSense, 0, Space.Self);
        

    }
}
