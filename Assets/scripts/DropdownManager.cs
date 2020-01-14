using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown myDrop;
    private AudioManager AM;
    void Start()
    {
        AM = FindObjectOfType<AudioManager>();
        myDrop.onValueChanged.AddListener(delegate
        {
            musicChange(myDrop);
        });
    }

    // Update is called once per frame
    void musicChange(Dropdown song)
    {
        switch (song.value)
        {
            case 0:
                AM.changeBGM("another");

                break;

            case 1:
                AM.changeBGM("come");
                break;

            case 2:
                AM.changeBGM("dern");
                break;

            case 3:
                AM.changeBGM("dream");
                break;

            case 4:
                AM.changeBGM("moby");
                break;

            case 5:
                AM.changeBGM("should");
                break;

            case 6:
                AM.changeBGM("safety");
                break;
        }
    }
}
