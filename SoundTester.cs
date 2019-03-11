using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundTester : MonoBehaviour
{

    //public GameObject pBar;
	public AudioSource soundManager;
    public AudioMixerSnapshot Pollution_0;
    public AudioMixerSnapshot Pollution_50;
    public AudioMixerSnapshot Pollution_90;
    public float pollutionLevel; //this will get the value from the class with the pollution variable

    // Start is called before the first frame update
    void Start()
    {
        
        //AudioSource fire = GetComponent<AudioSource>();
        //fire.clip = Resources.Load<AudioClip>("fire");
        pollutionLevel = GetComponent<PollutionSimulator>().pollution;
        
        //can I load all sounds in start like this?

    }

    // Update is called once per frame
    void Update()
    {
        //this was code to see if mixer worked
        //   if (Input.GetKeyDown("space"))
        //{

        // Debug.Log("hit space key");
        //       soundManager.Play();
        //}

        //   if(Input.GetKeyDown("right"))
        //   {
        //       Pollution_50.TransitionTo(2.0f);
        //       Debug.Log("siwthced to 50% pollution");
        //   }
        //   if(Input.GetKeyDown("left"))
        //   {
        //       Pollution_90.TransitionTo(1.7f);
        //       Debug.Log("switched to 90% pollution");
        //   }

        //I need to fix this so it's not constantly giving this messages, maybe make switch cases later?
        if (pollutionLevel >= 50.0f) 
        {
            Debug.Log("pollution has gone over 50%");
            Pollution_50.TransitionTo(2.0f);
        }
        if (pollutionLevel >= 90.0f)
        {
            Debug.Log("pollution has gone over 90%");
            Pollution_90.TransitionTo(1.7f);
        }
        if (pollutionLevel <= 50.0f)
        {
            Pollution_0.TransitionTo(2.0f);
            Debug.Log("pollution is under 50%");
        }


    }
    
    //void SwitchAudioSnapshots()
    //{

    //}
}
