using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigeraudio : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip specificClip;
    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        int playAudio = PlayerPrefs.GetInt("PlayAudio", 0); // Default to 0 if not set

        // If playAudio is 1, play the specific audio clip
        if (playAudio == 1)
        {
            audioSource.clip = specificClip;
            audioSource.Play();

            // Optionally reset the PlayerPrefs value after playing
            PlayerPrefs.SetInt("PlayAudio", 0); // Reset the key
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
