using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionV : MonoBehaviour
{
    public bool moveBool = false;



    public void formV(bool random)
    {
        moveBool = random;
        if (moveBool == true)
        {
            GameObject[] cubes;
            cubes = GameObject.FindGameObjectsWithTag("cube");
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[0].transform.position -= new Vector3(0, 0, -0.4f);
                cubes[1].transform.position -= new Vector3(0, 0, -0f);
                cubes[2].transform.position -= new Vector3(0, 0, 0.4f);
                cubes[3].transform.position -= new Vector3(0, 0, -0f);
                cubes[4].transform.position -= new Vector3(0, 0, -0.4f);
            }
        }

        if (moveBool == false)
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
