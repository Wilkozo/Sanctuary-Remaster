using UnityEngine.Audio;
using System;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;
using System.Collections;


public class AudioManager : MonoBehaviour
{
    public GameObject houseWorldBase;
    private SceneSwitcher HouseWorld;
    private bool WorldMusicActive = false;
    int MindState = 75; // 
    int StreetBusy = 0; // 
    int StateOfMind = PlayerStats.Hope;
    public Sound[] Sounds;
    public static AudioManager instance;

    private void Start()
    {

        // Following the same issue as stated above...
        if (WorldMusicActive == true)
       {
            if (StateOfMind < 33)
            {
                Play("BGtrackL");
            }
            else if (StateOfMind > 33 && StateOfMind < 66)
            {
                Play("BGtrackM");
            }
            else if (StateOfMind > 66)
            {
                Play("BGtrackH");
            }
            else
            {

            }

            float RandNum = UnityEngine.Random.Range(0, 100);
            if (RandNum <= 74)
            {
                Play("Wind");

            }
            else if (RandNum > 75)
            {
                Play("BusyAmbience");
            }
        }
    }
    // Use this for initialization
    void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
        }        
        else
        {
            Destroy(gameObject);
            return;
        }
        string CurrentScene = SceneManager.GetActiveScene().name;
        HouseWorld = houseWorldBase.GetComponent<SceneSwitcher>();
        // Complicated error when actively Testing there isn't any sound when audio being
        // Played is run through this check...
        if (CurrentScene == "HomeExt")
        {

            // Currently Appears In Other Scenes 
            // Where It Shouldn't Appear And Wont Update When
            // ReEntering The Ext Scenes Where it should appear and update on. 
            //DontDestroyOnLoad(gameObject);
            WorldMusicActive = true;
        }
        if (CurrentScene == "SchoolExt")
        {
            // Same Issue As Stated Above...
            //DontDestroyOnLoad(gameObject);
            WorldMusicActive = true;
        }
        foreach (Sound i in Sounds)
        {
            i.source = gameObject.AddComponent<AudioSource>();
            i.source.clip = i.Clip;

            i.source.volume = i.vol;
            i.source.pitch = i.pit;
            i.source.loop = i.loop;
        }
        if (WorldMusicActive == false)
        {

            //Destroy(gameObject);
        }
    }

    public void Play(string name)
    {
        Sound i = Array.Find(Sounds, Sound => Sound.name == name);
        if (i == null)
        {
            Debug.LogWarning("Sound / SFX" + name + " Missing!");
            return;
        }
        i.source.Play();
    }

    public void Stop(string name)
    {
        Sound i = Array.Find(Sounds, Sound => Sound.name == name);
        Debug.Log("Tracking lost, stopping audio");
        if (i.source.isPlaying)
        {
            i.source.Stop();
        }

        // rest of your code here
    }

}

