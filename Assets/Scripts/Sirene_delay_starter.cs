using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sirene_delay_starter : MonoBehaviour
{

    AudioSource m_MyAudioSource;

    //Play the music
    bool m_Play;
    //Detect when you use the toggle, ensures music isn’t played multiple times
    bool m_ToggleChange;

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        Invoke("Start_siren", 20);
        Invoke("Stop_siren", 180);
    }

    // Function to set the m_Play boolean to true after n seconds set by the invoke function in Start()
    void Start_siren()
    {
        Debug.Log("Starting Siren: "+Time.time);
        m_Play = true;
        m_ToggleChange = true;
    }
    void Stop_siren()
    {
        Debug.Log("Stopping Siren" + Time.time);
        m_Play = false;
        m_ToggleChange = true;
    }
    void Update()
    {
        //Check to see if you just set the toggle to positive
        if (m_Play == true && m_ToggleChange == true)
        {
            //Play the audio you attach to the AudioSource component
            Debug.Log("Playing Audiosource");
            m_MyAudioSource.Play();
            //Ensure audio doesn’t play more than once
            m_ToggleChange = false;
        }
        //Check if you just set the toggle to false
        if (m_Play == false && m_ToggleChange == true)
        {
            Debug.Log("Stopping Audiosource");
            //Stop the audio
            m_MyAudioSource.Stop();
            //Ensure audio doesn’t play more than once
            m_ToggleChange = false;
        }
    }

    //void OnGUI()
    //{
    //    //Switch this toggle to activate and deactivate the parent GameObject
    //    m_Play = GUI.Toggle(new Rect(10, 10, 100, 30), m_Play, "Play Music");

    //    //Detect if there is a change with the toggle
    //    if (GUI.changed)
    //    {
    //        //Change to true to show that there was just a change in the toggle state
    //        m_ToggleChange = true;
    //    }
    //}

}