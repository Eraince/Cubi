using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionW : MonoBehaviour
{
    public bool moveW = false;



    public void formW(bool random)
    {
        moveW = random;
        if (moveW == true)
        {
            GameObject[] cubes;
            cubes = GameObject.FindGameObjectsWithTag("cube");
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[0].transform.position -= new Vector3(0, 0, -0.3f);
                cubes[1].transform.position -= new Vector3(0, 0, 0.1f);
                cubes[2].transform.position -= new Vector3(0, 0, -0.3f);
                cubes[3].transform.position -= new Vector3(0, 0, 0.1f);
                cubes[4].transform.position -= new Vector3(0, 0, -0.3f);
            }
        }

        if (moveW == false)
        {
            GameObject[] cubes;
            cubes = GameObject.FindGameObjectsWithTag("cube");
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[0].transform.position = new Vector3(-6, 0.5f, 0);
                cubes[1].transform.position = new Vector3(-3, 0.5f, 0);
                cubes[2].transform.position = new Vector3(0, 0.5f, 0);
                cubes[3].transform.position = new Vector3(3, 0.5f, 0);
                cubes[4].transform.position = new Vector3(6, 0.5f, 0);

            }

        }


    }
}
