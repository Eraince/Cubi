using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeControl : MonoBehaviour
{
    public int band;
    public float startScale, scaleMultiplier;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (band == 3)
        //{
        //    Debug.Log(cubeGeneration.bandfreq[band]);
        //}

        var yChange = cubeGeneration.bandfreq[band] * scaleMultiplier + startScale;
        Debug.Log(yChange);
        //transform.localScale = new Vector3(transform.localScale.x, yChange, transform.localScale.z);
        if (yChange > 1 && yChange < 2) {
            transform.Translate(0, yChange * 0.8f * Time.deltaTime,0, Space.World);
        }

        if (yChange >= 2 && yChange < 3)
        {
            transform.Translate(0, yChange * Time.deltaTime, 0, Space.World);
        //    //transform.localScale = new Vector3(transform.localScale.x, yChange, transform.localScale.z);
        }

        if (yChange >= 3 && yChange <3.5) {
            transform.Rotate(yChange * 90*  Time.deltaTime,0,0, Space.World);
            //transform.Translate(0, 0, yChange * 1.4f * Time.deltaTime);
        }

        if (yChange >= 5 && yChange <6.2) {
            //GetComponent<Rigidbody>().AddForce(0, yChange * 15,0);
            transform.Translate(0, yChange * 1.2f * Time.deltaTime, 0, Space.World);

        }

        if (yChange >= 6.2 && yChange <6.7) {
            transform.Translate(0, yChange * 1.4f * Time.deltaTime, 0, Space.World);
        }

        //if (yChange >= 7)
        //{
        //    transform.Translate(0, yChange * 2f * Time.deltaTime, 0,Space.World);
        //}

        ////GetComponent<Rigidbody>().AddForce(0, 5F, 0);
    }
}
