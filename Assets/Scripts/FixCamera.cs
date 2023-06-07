using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCamera : MonoBehaviour
{
    public new Camera camera;
    public Camera mainCamera;
    public GameObject avatar;

    void Update()
    {
        camera.transform.SetPositionAndRotation(camera.GetComponentInParent<Transform>().position,
            Quaternion.Euler(0, 0, 180));
    }

    //private float GetRelativeAngle() 
    //{
    //    float dz = mainCamera.transform.z - camera.transform.position.z;    
    //    float dx = mainCamera.transform.position.x - camera.transform.position.x;

    //    Debug.Log("dx: " + dx + " dz: " + dz);

    //    float angle = Mathf.Tan(dz / dx) * Mathf.Rad2Deg;

    //    Debug.Log(angle);

    //    return angle;
    //}
}
