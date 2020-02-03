using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Car;
    public float Speed;
    public float CameraSense;
    private float holdtime = 0;
    private float deceleration;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            if (holdtime < deceleration)
                holdtime = deceleration;
            Car.transform.Translate(0, 0, 0.1f * holdtime);
            if (holdtime < Speed)
                holdtime += 0.05f;
        }
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

        if (Input.GetKeyUp("w"))
        {
            deceleration = holdtime;
            holdtime = 0;
        }

        if (Input.GetKeyUp("w") && Input.GetKey("a"))
        {
            deceleration = holdtime;
            holdtime = 0;
        }

        if (Input.GetKeyUp("w") && Input.GetKey("d"))
        {
            deceleration = holdtime;
            holdtime = 0;
        }

        if (!Input.GetKeyUp("w"))
        {
            Car.transform.Translate(0, 0, 0.1f * deceleration);
            if (deceleration < 0.1)
                deceleration = 0;
            if (deceleration > 0)
                deceleration -= 0.05f;

        }
            

    }
}
