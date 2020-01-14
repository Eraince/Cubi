using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionRandom : MonoBehaviour
{
    public bool moveRandom = false;

    public void formRandom(bool random)
    {
        moveRandom = random;
        if (moveRandom == true)
        {
            GameObject[] cubes;
            cubes = GameObject.FindGameObjectsWithTag("cube");
            for (int i = 0; i < cubes.Length; i++)
            {
                float move = Random.Range(-1f, 4.0f);
                cubes[i].transform.position += new Vector3(0, 0, move);
            }
        }

        if (moveRandom == false)
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
