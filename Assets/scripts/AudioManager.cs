using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    AudioSource audiosource;
    public Sound[] sounds;
    public Sound current;
    // void Start()
    // {
    //     current.source.Play();
    // }

    // Start is called before the first frame update
    void Awake()
    {

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.loop = s.loop;
            s.source.playOnAwake = s.playOnWake;
            if (s.name == "another")
            {
                s.source.Play();
                current = s;
            }

        }


    }


    public void changeBGM(string name)
    {
        foreach (Sound s in sounds)
        {
            s.source.Stop();

            if (s.name == name)
            {
                s.source.Play();
                current = s;

            }
        }
    }


    void update()
    {


    }

    public void changeVolume(float scale)
    {

        current.source.volume = scale;
    }



}
