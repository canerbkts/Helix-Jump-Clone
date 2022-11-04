using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RotatePlatform();        
    }
    private float startingPosition;
    public float rotatespeed = 5000f;
    private void RotatePlatform()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startingPosition = touch.position.x;
                    break;
                case TouchPhase.Moved:
                    if (startingPosition > touch.position.x)
                    {
                        transform.RotateAround(transform.position, transform.up, rotatespeed * Time.deltaTime*15);
                    }
                    else if (startingPosition < touch.position.x)
                    {
                        transform.RotateAround(transform.position, transform.up, -rotatespeed * Time.deltaTime*15);
                    }
                    startingPosition = touch.position.x;
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Touch Phase Ended.");
                    break;
            }
        }
    }
}

