using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionReset : MonoBehaviour
{
    // Start is called before the first frame update
    public void formReset()
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
