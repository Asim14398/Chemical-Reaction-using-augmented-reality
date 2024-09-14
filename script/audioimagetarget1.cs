using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioimagetarget1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
       
        
        audioSource = GetComponent<AudioSource>();
    }
    public AudioSource[] audioClips;
    private int currentClipIndex = 0;
    private AudioSource audioSource;
    private bool v = true;
   
    public void PlayNextClip1()
    {
        if (currentClipIndex > audioClips.Length - 2)
        {

            currentClipIndex = 0;
            audioSource.clip = audioClips[currentClipIndex].clip;
            audioSource.Play();
        }
        else
        {

            currentClipIndex++;
            audioSource.clip = audioClips[currentClipIndex].clip;
            audioSource.Play();
            Debug.Log(currentClipIndex);
        }
    }

    public void PlayPreviousAudioClip2()
    {
        if (currentClipIndex < 1)
        {
            currentClipIndex = audioClips.Length - 1;

            audioSource.clip = audioClips[currentClipIndex].clip;
            audioSource.Play();
        }
        else
        {
            currentClipIndex--;
            audioSource.clip = audioClips[currentClipIndex].clip;
            audioSource.Play();

        }
    }
    private bool audioplay = true;
    public void stopaudio1()
    {
        audioSource.clip = audioClips[currentClipIndex].clip;
        audioSource.Pause();
        audioplay = true;
    }
    public void playaudio1()
    {
        if (audioplay == true)
        {
            if (target == true)
            {
                if (but == false)

                {




                    audioSource.clip = audioClips[currentClipIndex].clip;
                    audioSource.Play();
                    audioplay = false;
                }
            }
        }

    }


    public void ResetSequence()
    {
        currentClipIndex = 0;
    }
    public void playmodel()
    {
        if (v == true)
        {
            audioSource.clip = audioClips[0].clip;
            audioSource.Play();
            v = false;
        }
    }
    private void Update()
    {
        float distance = PlayerPrefs.GetFloat("ObjectDistance", -1.0f); // Default to -1 if not set

        if (distance >= 0 && distance < 1.0f)
        {
            stopaudio1(); // Stop audio if distance is less than 0.1
        }
        else if (but)
        {
            stopaudio1();
        }
      
        else if (!but)
        {
            playaudio1(); // Play audio otherwise
        }

    }

   bool but = false;

    public void speaker()
    {

        if (but == true)
        {
            
            but = false;

        }
        else
        {

            but = true;
        }
    }
    bool target = false;
    public void found()
    {
        target = true;
    }
    public void lost()
    {
        target = false;
    }
}


