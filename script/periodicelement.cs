using EasyUI.Toast;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using Unity.VisualScripting;

public class periodicelement : MonoBehaviour
{
    public GameObject[] modelPrefabs;
     public int myIntValue;
    private int currentModelIndex;
    
    public GameObject button1,button2,volup,voldown;
    bool volume=false;
    bool target = false;
    
    public void onshow()
    {
        button1.SetActive(true);

        button2.SetActive(true);

    }
    public void found()
    {
        target = true;
    }
    public void lost()
    {
        target = false;
    }

    public void onhide()
    {
        button1.SetActive(false);

        button2.SetActive(false);
    }

    public void backto()
    {

        PlayerPrefs.SetInt("ScoreToPass", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene("registeration");

    }
    public void volumedown()
    {
        volume = false;
    }
    public void volumeup()
    {
        volume = true;
    }


    public void OnButtonClick()
    {

        if (currentModelIndex > modelPrefabs.Length - 2)
        {
            // If we have displayed all the models, reset to the beginning of the sequence

            modelPrefabs[currentModelIndex].SetActive(false);

            currentModelIndex = 0;

            modelPrefabs[currentModelIndex].SetActive(true);


        }
        else
        {

            modelPrefabs[currentModelIndex].SetActive(false);
            currentModelIndex++;
            modelPrefabs[currentModelIndex].SetActive(true);
        }

    }
    public void OnBackButtonClick()
    {


        if (currentModelIndex < 1)
        {
            // If we reached the first model in the sequence, go to the last model
            modelPrefabs[currentModelIndex].SetActive(false);
            currentModelIndex = modelPrefabs.Length - 1;
            modelPrefabs[currentModelIndex].SetActive(true);
        }
        else
        {
            modelPrefabs[currentModelIndex].SetActive(false);
            currentModelIndex--;
            modelPrefabs[currentModelIndex].SetActive(true);
        }
    }
    private bool v = true;

    private int currentClipIndex=0;
    private void Start()
    {

        
        myIntValue = PlayerPrefs.GetInt("MyIntValue");
        Debug.Log(myIntValue);
        currentModelIndex = myIntValue;
        currentClipIndex = myIntValue;
        audioSource = GetComponent<AudioSource>();
       

    }
    public AudioSource[] audioClips;
    
    private AudioSource audioSource;
    public void playmodel()
    {
        if (v == true)
        {
            
            modelPrefabs[currentModelIndex].SetActive(true);
            audioSource.clip = audioClips[0].clip;
            audioSource.Play();
            v = false;
        }
    }
    private void Update()
    {
        if (volume == false)
        {
            stopaudio();
            voldown.SetActive(true);
            volup.SetActive(false);
            playaudio();
        }
        if (volume == true)
        {
            stopaudio();
            volup.SetActive(true);
            voldown.SetActive(false);
            playaudio();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetInt("ScoreToPass", 1);
            PlayerPrefs.Save();

            SceneManager.LoadScene("registeration");

       }

    }


    public void PlayNextClip()
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

    public void PlayPreviousAudioClip()
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
    private bool audioplay = false;
    public void stopaudio()
    {
        audioSource.clip = audioClips[currentClipIndex].clip;
        audioSource.Pause();
        audioplay = true;
    }
    public void playaudio()
    {
        if (target == true)
        {
            if (volume == true)
            {
                if (audioplay == true)
                {


                    audioSource.clip = audioClips[currentClipIndex].clip;
                    audioSource.Play();
                    audioplay = false;
                }
            }
        }
    }
    

}
