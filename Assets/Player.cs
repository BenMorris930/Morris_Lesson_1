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
    private float acaccel = 0;
    private float dcaccel = 0;
    public float RSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            Car.transform.Translate(0, 0, 0.1f * holdtime);
            if (holdtime < Speed)
                holdtime += 0.05f;
        }

        if (Input.GetKey("s"))
        {
            Car.transform.Translate(0, 0, 0.1f * holdtime);
            if (holdtime > RSpeed)
                holdtime -= 0.2f;
        }

        if (!Input.GetKey("s") && !Input.GetKey("w"))
        {
            Car.transform.Translate(0, 0, 0.1f * holdtime);
            if (holdtime > 0)
                holdtime -= 0.05f;
            if (holdtime < 0)
                holdtime += 0.05f;
        }

        
    }
}
