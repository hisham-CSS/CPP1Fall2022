using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float minXClamp;
    public float maxXClamp;

    //bool isScrollingUp = false;

    // Update is called once per frame
    void LateUpdate()
    {
        //if (!isScrollingUp)
        //{ 
        Vector3 cameraPosition;

        cameraPosition = transform.position;
        cameraPosition.x = Mathf.Clamp(player.transform.position.x, minXClamp, maxXClamp);

        transform.position = cameraPosition;
        //}
        //else
        //{
        //now do my verticle scroll which is basically the same thing as above but with the Y coordinate
        //}
    }
}
