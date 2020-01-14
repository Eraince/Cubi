using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeChangeColor : MonoBehaviour
{
    public Button Pink, Purple, Blue, Random;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
       Pink.onClick.AddListener(ChangeRed);
       Purple.onClick.AddListener(ChangePurple);
       Blue.onClick.AddListener(ChangeBlue);
       Random.onClick.AddListener(ChangeRandom);
    }

    void ChangeRed() {
        Debug.Log("Red");
        GameObject[] cubes;
        cubes = GameObject.FindGameObjectsWithTag("cube");
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].GetComponent<Renderer>().material.color = new Color(255f / 255f, 0, 255f / 255f);
        }
  
    }

    void ChangePurple()
    {
        Debug.Log("Purple");
        GameObject[] cubes;
        cubes = GameObject.FindGameObjectsWithTag("cube");
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].GetComponent<Renderer>().material.color = new Color(140f / 255f, 28f / 255f, 255f / 255f);
        }

    }

    void ChangeBlue()
    {
        Debug.Log("Blue");
        GameObject[] cubes;
        cubes = GameObject.FindGameObjectsWithTag("cube");
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].GetComponent<Renderer>().material.color = new Color(0, 25f / 255f, 255f / 255f);
        }

    }

    void ChangeRandom()
    {
        Debug.Log("Random Color");
        GameObject[] cubes;
        cubes = GameObject.FindGameObjectsWithTag("cube");
        for (int i = 0; i < cubes.Length; i++)
        {
            //float move = Random.Range(0f, 1.0f);
            cubes[i].GetComponent<Renderer>().material.color = new Color((i*50f+50)/255f, (i*30+50) / 255f, (i*50f+50) / 255f);
        }

    }

}
