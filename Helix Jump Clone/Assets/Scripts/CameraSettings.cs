using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
    public static CameraSettings Instance;

    private Vector3 targetPosition;
    public bool isLerp=false;
    void Start()
    {        
        Instance = this;
        SetTarget();
    }

    public void SetTarget()
    {
        targetPosition = new Vector3(0f, transform.position.y - (float)1.5, -4.07f);
    }

    public IEnumerator SetCameraPos()
    {
        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, 4.0f * Time.deltaTime);
            yield return null;
        }
        SetTarget();  
    }
}
