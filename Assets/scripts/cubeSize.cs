using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeSize : MonoBehaviour
{
    public float sizeSpeed;


    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0, sizeSpeed, 0);
    }

    public void adjustSizeSpeed(float newSpeed) {
        sizeSpeed = newSpeed;
    }
}
