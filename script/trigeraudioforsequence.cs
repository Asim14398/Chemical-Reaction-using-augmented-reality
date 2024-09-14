using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigeraudioforsequence : MonoBehaviour
{
    public AudioSource audioClips1, audioClips2, audioClips3, audioClips4, audioClips5, audioClips6, audioClips7, audioClips8, audioClips9, audioClips10, audioClips11, audioClips12, audioClips13, audioClips14, audioClips15, audioClips16, audioClips17;
    private AudioSource audioSource;
    private int value;
    // Start is called before the first frame update
    void Start()
    {
        value = PlayerPrefs.GetInt("trigervalue", 0);
        if (value == 1)
        {

            audioSource.clip = audioClips1.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 2)
        {
            audioSource.clip = audioClips2.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 3)
        {
            audioSource.clip = audioClips3.clip;
            audioSource.Play(); Debug.Log(value);
        }
        else if (value == 4)
        {
            audioSource.clip = audioClips4.clip;
            audioSource.Play(); Debug.Log(value);
        }
        else if (value == 5)
        {
            audioSource.clip = audioClips5.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 6)
        {
            audioSource.clip = audioClips6.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 7)
        {
            audioSource.clip = audioClips7.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 8)
        {
            audioSource.clip = audioClips8.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 9)
        {
            audioSource.clip = audioClips9.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 10)
        {
            audioSource.clip = audioClips10.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 11)
        {
            audioSource.clip = audioClips11.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 12)
        {
            audioSource.clip = audioClips12.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 13)
        {
            audioSource.clip = audioClips5.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 5)
        {
            audioSource.clip = audioClips13.clip;
            audioSource.Play();
            Debug.Log(value);
        }
        else if (value == 14)
        {
            audioSource.clip = audioClips14.clip;
            audioSource.Play(); Debug.Log(value);

        }
        else if (value == 15)
        {
            audioSource.clip = audioClips15.clip;
            audioSource.Play(); Debug.Log(value);

        }
        else if (value == 16)
        {
            audioSource.clip = audioClips16.clip;
            audioSource.Play(); Debug.Log(value);

        }
        else if (value == 17)
        {
            audioSource.clip = audioClips17.clip;
            audioSource.Play(); Debug.Log(value);

        }
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    
}
