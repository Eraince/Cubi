using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class cubeGeneration : MonoBehaviour
{

    AudioSource audiosource;
    public static float[] smaples = new float[256];
    public static float[] bandfreq = new float[5];
    private AudioManager AM;
    // Start is called before the first frame update
    void Start()
    {
        AM = FindObjectOfType<AudioManager>();

    }

    // Update is called once per frame
    void Update()
    {
        audiosource = AM.current.source;


        audiosource.GetSpectrumData(smaples, 0, FFTWindow.Blackman);
        makeFrequencyBand();
    }
    void makeFrequencyBand()
    {
        // 0   8  0-688HZ
        // 1   16  689-2065HZ
        // 2   32  2066-4818HZ
        // 3   64  4819-10323HZ
        // 4   128 10324-21332HZå


        int count = 0;
        for (int i = 0; i < 5; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i + 3);
            for (int j = 0; j < sampleCount; j++)
            {
                average += smaples[count] * (count + 1);
                count++;
            }
            average /= count;
            bandfreq[i] = average * 10;
        }
    }
}
