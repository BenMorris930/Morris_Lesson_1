using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Car;
    public float Speed = 5;
    public float CameraSense = 1;
    public float FollowDist = 10;
    private float holdtime = 0;
    private float acaccel = 0;
    private float dcaccel = 0;
    private float RSpeed = -0.75f;
    private float lastrotate;

    // Start is called before the first frame update
    void Start()
    {
        lastrotate = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // float deltarotate = Car.transform.rotation.y - lastrotate;
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
                holdtime -= 0.1f;
        }

        if (!Input.GetKey("s") && !Input.GetKey("w"))
        {
            Car.transform.Translate(0, 0, 0.1f * holdtime);
            if (holdtime > 0)
                holdtime -= 0.05f;
            if (holdtime < 0)
                holdtime += 0.05f;
        }

        if (Input.GetKey("a"))
        {
            if (holdtime < 0)
            {
                Car.transform.Rotate(0, 1 * acaccel * CameraSense, 0);
                if (acaccel < 1)
                    acaccel += 0.05f;
            }
            else if (holdtime > 0)
            {
                Car.transform.Rotate(0, -1 * acaccel * CameraSense, 0);
                if (acaccel < 1)
                    acaccel += 0.05f;
            }
        }
        else acaccel = 0;

        if (Input.GetKey("d"))
        {
            if (holdtime < 0)
            {
                Car.transform.Rotate(0, -1 * dcaccel * CameraSense, 0);
                if (dcaccel < 1)
                    dcaccel += 0.05f;
            }
            else if (holdtime > 0)
            {
                Car.transform.Rotate(0, 1 * dcaccel * CameraSense, 0);
                if (dcaccel < 1)
                    dcaccel += 0.05f;
            }
        }
        else dcaccel = 0;

        
        // transform.position = new Vector3(FollowDist - Mathf.Cos(deltarotate), 7, Mathf.Sin(deltarotate));
        // lastrotate = Car.transform.rotation.y;
    }
    }


