using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EasyUI.Toast;
using Unity.VisualScripting;
using static UnityEngine.GraphicsBuffer;

public class sequence : MonoBehaviour
{
    public GameObject[] modelPrefabs;
    public GameObject[] modelPrefabs1;
    private int myVariable;
   
    string guiText;

    // An array to hold all your 3D model prefabs
    private int currentModelIndex = 0; // Keeps track of the current model index
    private int currentModelIndex1 = 0;
    public void OnButtonClick()
    {
        if (currentModelIndex > modelPrefabs.Length -2)
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
            modelPrefabs[currentModelIndex].SetActive(true) ;
        }
        else
        {
            modelPrefabs[currentModelIndex].SetActive(false);
            currentModelIndex--;
            modelPrefabs[currentModelIndex].SetActive(true) ;
        }
    }
    public void OnButtonClick1()
    {
        if (currentModelIndex1 > modelPrefabs1.Length - 2)
        {
            // If we have displayed all the models, reset to the beginning of the sequence

            modelPrefabs1[currentModelIndex1].SetActive(false);

            currentModelIndex1 = 0;

            modelPrefabs1[currentModelIndex1].SetActive(true);


        }
        else
        {

            modelPrefabs1[currentModelIndex1].SetActive(false);
            currentModelIndex1++;
            modelPrefabs1[currentModelIndex1].SetActive(true);
        }

    }
    public void OnBackButtonClick1()
    {


        if (currentModelIndex1 < 1)
        {
            // If we reached the first model in the sequence, go to the last model
            modelPrefabs1[currentModelIndex1].SetActive(false);
            currentModelIndex1 = modelPrefabs1.Length - 1;
            modelPrefabs1[currentModelIndex1].SetActive(true);
        }
        else
        {
            modelPrefabs1[currentModelIndex1].SetActive(false);
            currentModelIndex1--;
            modelPrefabs1[currentModelIndex1].SetActive(true);
        }
    }
    public void GoBackToMainScene()
    {

        myVariable = 1;
        PlayerPrefs.SetInt("MyVariable", myVariable);
        SceneManager.LoadScene("registeration");

    }
    public GameObject object1; // Reference to the first object
    public GameObject object2; // Reference to the second object
    private bool v = true;
    public AudioSource audioClips1, audioClips2, audioClips3, audioClips21, audioClips19, audioClips20, audioClips4, audioClips5, audioClips18, audioClips6, audioClips7, audioClips8, audioClips9, audioClips10, audioClips11, audioClips12, audioClips13, audioClips14, audioClips15, audioClips16, audioClips17;
    private AudioSource audioSource1;
    public GameObject h2o;
    public GameObject water;
    public GameObject nacl;
    public GameObject nacl1;
    public GameObject zncl2;
    public GameObject zncl;
    public GameObject hydrogen;
    public GameObject hydrogen1;
    public GameObject nacl_1;
    public GameObject cloud;
    public GameObject water1;
    public GameObject reg4;
    public GameObject reg5;
    public GameObject caoh2;
    public GameObject reg6;
    public GameObject fes;
    public GameObject reg7;
    public GameObject mgcl2;
    public GameObject h2;
    public GameObject re8;
    public GameObject re8_1;
    public GameObject re9;
    public GameObject re9_1;
    public GameObject re9_2;
    public GameObject re10;
    public GameObject re10_1;
    public GameObject h2o1;
    public GameObject water12;
    public GameObject re12,re12_1,re12_2,re12_3;
    public GameObject re13,re13_1,re13_2,re13_3;
    public GameObject re14, re14_1, re14_2;
    public GameObject re17, re17_1, re17_2;
    public GameObject re15, re15_1, re15_2;
     public GameObject re18, re18_1;
    public GameObject re19, re19_1,re20,re20_1,re21,re21_1,re22,re22_1;
    public GameObject explosion;
    private bool model=false;
    private bool target1 = false;
    private bool v1 = true;
    private void Start()
    {
        if (but==true) { speakoff.SetActive(true); but = false; }
        if (object1 == null || object2 == null)
        {
            Debug.LogError("Please assign both object references in the Inspector.");
        }

        audioSource = GetComponent<AudioSource>();
        audioSource1 = GetComponent<AudioSource>();

    }
    public void playmodel()
    {
        if (v == true) {
            modelPrefabs[0].SetActive(true);
            audioSource.clip = audioClips[0].clip;
            audioSource.Play();
            v= false;
        }
    }
    public void playmodel1()
    {
        if (v1 == true)
        {
            modelPrefabs1[0].SetActive(true);
            v1 = false;
        }
    }

    private void Update()
    {

        // Check for the Android back button press
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
                myVariable = 1;
                PlayerPrefs.SetInt("MyVariable", myVariable);
                SceneManager.LoadScene("registeration");
            
        }


        if (object1 != null && object2 != null)
        {
            // Calculate the distance between the two objects
            float distance = Vector3.Distance(object1.transform.position, object2.transform.position);
            Debug.Log(distance);
       guiText=(distance/10).ToString();
            PlayerPrefs.SetFloat("ObjectDistance", distance);


            // You can display the distance or use it for other purposes
            if (distance < 1.0f)

            { 
                canvas.SetActive(false);
                canvas1.SetActive(false);
                if (modelPrefabs[10].active && modelPrefabs1[17].active)
                {
                    h2o.SetActive(true);
                    water.SetActive(true);
                    nacl.SetActive(true);
                    nacl1.SetActive(true);
                    modelPrefabs[10].SetActive(false);
                    modelPrefabs1[17].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips1.clip;
                        audioSource1.Play();
                    }
                    model = true;
                }
                else if (modelPrefabs[17].active && modelPrefabs1[10].active)
                {

                    h2o.SetActive(true);
                    water.SetActive(true);
                    nacl.SetActive(true);
                    nacl1.SetActive(true);
                    modelPrefabs[17].SetActive(false);
                    modelPrefabs1[10].SetActive(false);
                    audioSource.Pause(); if (but == false && target1)
                    {


                        audioSource1.clip = audioClips1.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[22].active && modelPrefabs1[10].active)
                {

                    zncl2.SetActive(true);
                    zncl.SetActive(true);
                    hydrogen.SetActive(true);
                    hydrogen1.SetActive(true);
                    modelPrefabs[22].SetActive(false);
                    modelPrefabs1[10].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips2.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[10].active && modelPrefabs1[22].active)
                {

                    zncl2.SetActive(true);
                    zncl.SetActive(true);
                    hydrogen.SetActive(true);
                    hydrogen1.SetActive(true);
                    modelPrefabs[10].SetActive(false);
                    modelPrefabs1[22].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips2.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[0].active && modelPrefabs1[19].active)
                {

                    reg4.SetActive(true);
                    nacl_1.SetActive(true);
                    cloud.SetActive(true);
                    water1.SetActive(true);
                    modelPrefabs[0].SetActive(false);
                    modelPrefabs1[19].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips3.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[19].active && modelPrefabs1[0].active)
                {
                    reg4.SetActive(true);
                    nacl_1.SetActive(true);
                    cloud.SetActive(true);
                    water1.SetActive(true);
                    modelPrefabs[19].SetActive(false);
                    modelPrefabs1[0].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips3.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[4].active && modelPrefabs1[9].active)
                {
                    reg5.SetActive(true);
                    caoh2.SetActive(true);
                    modelPrefabs[4].SetActive(false);
                    modelPrefabs1[9].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips4.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[9].active && modelPrefabs1[4].active)
                {
                    reg5.SetActive(true);
                    caoh2.SetActive(true);
                    modelPrefabs[9].SetActive(false);
                    modelPrefabs1[4].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips4.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[11].active && modelPrefabs1[21].active)
                {
                    reg6.SetActive(true);
                    fes.SetActive(true);
                    modelPrefabs[11].SetActive(false);
                    modelPrefabs1[21].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips5.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[21].active && modelPrefabs1[11].active)
                {
                    reg6.SetActive(true);
                    fes.SetActive(true);
                    modelPrefabs[21].SetActive(false);
                    modelPrefabs1[11].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips5.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[0].active && modelPrefabs1[12].active)
                {
                    reg7.SetActive(true);
                    mgcl2.SetActive(true);
                    h2.SetActive(true);
                    modelPrefabs[0].SetActive(false);
                    modelPrefabs1[12].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips6.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[12].active && modelPrefabs1[0].active)
                {
                    reg7.SetActive(true);
                    mgcl2.SetActive(true);
                    h2.SetActive(true);
                    modelPrefabs[12].SetActive(false);
                    modelPrefabs1[0].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips6.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[10].active && modelPrefabs1[26].active)
                {
                    re8.SetActive(true);
                    re8_1.SetActive(true);
                    modelPrefabs[10].SetActive(false);
                    modelPrefabs1[26].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips7.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[26].active && modelPrefabs1[10].active)
                {
                    re8.SetActive(true);
                    re8_1.SetActive(true);
                    modelPrefabs[26].SetActive(false);
                    modelPrefabs1[10].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips7.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[1].active && modelPrefabs1[2].active)
                {
                    re9.SetActive(true);
                    re9_1.SetActive(true);
                    re9_2.SetActive(true);
                    modelPrefabs[1].SetActive(false);
                    modelPrefabs1[2].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips8.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[2].active && modelPrefabs1[1].active)
                {
                    re9.SetActive(true);
                    re9_1.SetActive(true);
                    re9_2.SetActive(true);
                    modelPrefabs[2].SetActive(false);
                    modelPrefabs1[1].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips8.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[5].active && modelPrefabs1[9].active)
                {
                    re10.SetActive(true);
                    re10_1.SetActive(true);
                    modelPrefabs[5].SetActive(false);
                    modelPrefabs1[9].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips9.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[9].active && modelPrefabs1[5].active)
                {
                    re10.SetActive(true);
                    re10_1.SetActive(true);
                    modelPrefabs[9].SetActive(false);
                    modelPrefabs1[5].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips9.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[6].active && modelPrefabs1[24].active)
                {
                    h2o1.SetActive(true);
                    water12.SetActive(true);
                    modelPrefabs[6].SetActive(false);
                    modelPrefabs1[24].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips10.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[24].active && modelPrefabs1[6].active)
                {
                    h2o1.SetActive(true);
                    water12.SetActive(true);
                    modelPrefabs[24].SetActive(false);
                    modelPrefabs1[6].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips10.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }


                else if (modelPrefabs[25].active && modelPrefabs1[10].active)
                {
                    re12.SetActive(true);
                    re12_1.SetActive(true);
                    re12_2.SetActive(true);
                    re12_3.SetActive(true);
                    modelPrefabs[25].SetActive(false);
                    modelPrefabs1[10].SetActive(false);
                    audioSource.Pause(); if (but == false && target1)
                    {


                        audioSource1.clip = audioClips11.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[10].active && modelPrefabs1[25].active)
                {
                    re12.SetActive(true);
                    re12_1.SetActive(true);
                    re12_2.SetActive(true);
                    re12_3.SetActive(true);
                    modelPrefabs[10].SetActive(false);
                    modelPrefabs1[25].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips11.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }

                else if (modelPrefabs[10].active && modelPrefabs1[11].active)
                {
                    re13.SetActive(true);
                    re13_1.SetActive(true);
                    re13_2.SetActive(true);
                    re13_3.SetActive(true);
                    modelPrefabs[10].SetActive(false);
                    modelPrefabs1[11].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips12.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[11].active && modelPrefabs1[10].active)
                {
                    re13.SetActive(true);
                    re13_1.SetActive(true);
                    re13_2.SetActive(true);
                    re13_3.SetActive(true);
                    modelPrefabs[11].SetActive(false);
                    modelPrefabs1[10].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips12.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[23].active && modelPrefabs1[17].active)
                {
                    re14.SetActive(true);
                    re14_1.SetActive(true);
                    re14_2.SetActive(true);
                    modelPrefabs[23].SetActive(false);
                    modelPrefabs1[17].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips13.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }

                else if (modelPrefabs[17].active && modelPrefabs1[23].active)
                {
                    re14.SetActive(true);
                    re14_1.SetActive(true);
                    re14_2.SetActive(true);
                    modelPrefabs[17].SetActive(false);
                    modelPrefabs1[23].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips13.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[16].active && modelPrefabs1[20].active)
                {
                    re17.SetActive(true);
                    re17_1.SetActive(true);
                    re17_2.SetActive(true);
                    modelPrefabs[16].SetActive(false);
                    modelPrefabs1[20].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips14.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[20].active && modelPrefabs1[16].active)
                {
                    re17.SetActive(true);
                    re17_1.SetActive(true);
                    re17_2.SetActive(true);
                    modelPrefabs[16].SetActive(false);
                    modelPrefabs1[20].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips14.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[6].active && modelPrefabs1[14].active)
                {
                    re15.SetActive(true);
                    re15_1.SetActive(true);
                    re15_2.SetActive(true);
                    modelPrefabs[6].SetActive(false);
                    modelPrefabs1[14].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips15.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[14].active && modelPrefabs1[6].active)
                {
                    re15.SetActive(true);
                    re15_1.SetActive(true);
                    re15_2.SetActive(true);
                    modelPrefabs[14].SetActive(false);
                    modelPrefabs1[6].SetActive(false);
                    audioSource.Pause(); if (but == false && target1)
                    {


                        audioSource1.clip = audioClips15.clip;
                        audioSource1.Play();
                    }

                    model = true;

                }
                else if (modelPrefabs[7].active && modelPrefabs1[15].active)
                {
                    re18.SetActive(true);
                    re18_1.SetActive(true);
                    modelPrefabs[7].SetActive(false);
                    modelPrefabs1[15].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips16.clip;
                        audioSource1.Play();
                    }

                    model = true;

                }
                else if (modelPrefabs[15].active && modelPrefabs1[7].active)
                {
                    re18.SetActive(true);
                    re18_1.SetActive(true);
                    modelPrefabs[15].SetActive(false);
                    modelPrefabs1[7].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {
                        audioSource1.clip = audioClips16.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[6].active && modelPrefabs1[11].active)
                {
                    re19.SetActive(true);
                    re19_1.SetActive(true);
                    modelPrefabs[6].SetActive(false);
                    modelPrefabs1[11].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {


                        audioSource1.clip = audioClips17.clip;
                        audioSource1.Play();
                    }
                    model = true;

                }
                else if (modelPrefabs[11].active && modelPrefabs1[6].active)
                {
                    re19.SetActive(true);
                    re19_1.SetActive(true);
                    modelPrefabs[11].SetActive(false);
                    modelPrefabs1[6].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {
                        audioSource1.clip = audioClips17.clip;
                        audioSource1.Play();
                    }
                    model = true;


                }
                else if (modelPrefabs[13].active && modelPrefabs1[27].active)
                {
                    re20.SetActive(true);
                    re20_1.SetActive(true);
                    modelPrefabs[13].SetActive(false);
                    modelPrefabs1[27].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {
                        audioSource1.clip = audioClips19.clip;
                        audioSource1.Play();
                    }
                    model = true;


                }
                else if (modelPrefabs[27].active && modelPrefabs1[13].active)
                {
                    re20.SetActive(true);
                    re20_1.SetActive(true);
                    modelPrefabs[27].SetActive(false);
                    modelPrefabs1[13].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {
                        audioSource1.clip = audioClips19.clip;
                        audioSource1.Play();
                    }
                    model = true;


                }
                else if (modelPrefabs[2].active && modelPrefabs1[27].active)
                {
                    re21.SetActive(true);
                    re21_1.SetActive(true);
                    modelPrefabs[2].SetActive(false);
                    modelPrefabs1[27].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {
                        audioSource1.clip = audioClips20.clip;
                        audioSource1.Play();
                    }
                    model = true;


                }
                else if (modelPrefabs[27].active && modelPrefabs1[2].active)
                {
                    re21.SetActive(true);
                    re21_1.SetActive(true);
                    modelPrefabs[27].SetActive(false);
                    modelPrefabs1[2].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {
                        audioSource1.clip = audioClips20.clip;
                        audioSource1.Play();
                    }
                    model = true;


                }
                else if (modelPrefabs[27].active && modelPrefabs1[7].active)
                {
                    re22.SetActive(true);
                    re22_1.SetActive(true);
                    modelPrefabs[27].SetActive(false);
                    modelPrefabs1[7].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {
                        audioSource1.clip = audioClips21.clip;
                        audioSource1.Play();
                    }
                    model = true;


                }
                else if (modelPrefabs[7].active && modelPrefabs1[27].active)
                {
                    re22.SetActive(true);
                    re22_1.SetActive(true);
                    modelPrefabs[7].SetActive(false);
                    modelPrefabs1[27].SetActive(false);
                    audioSource.Pause();
                    if (but == false && target1)
                    {
                        audioSource1.clip = audioClips21.clip;
                        audioSource1.Play();
                    }
                    model = true;


                }

                else
                {
                    if (model == false)
                    {
                        modelPrefabs[currentModelIndex].SetActive(false);
                        modelPrefabs1[currentModelIndex1].SetActive(false);
                        audioSource.Pause();
                       
                            explosion.SetActive(true);
                        if (target1 == true&&but==false)
                        {
                            audioSource1.clip = audioClips18.clip;
                            audioSource1.Play();
                        }
                        else
                        {
                            audioSource1.Pause();
                        }
                    }
                }
            }
            else if(distance >1)
            {
                model = false;

                re21.SetActive(false);
                re21_1.SetActive(false);
                re22.SetActive(false);
                re22_1.SetActive(false);
                re20.SetActive(false);
                re20_1.SetActive(false);
                explosion.SetActive(false);
                h2o.SetActive(false);
                water.SetActive(false);
                nacl.SetActive(false);
                nacl1.SetActive(false);
                re18.SetActive(false);
                re19.SetActive(false);
                re19_1.SetActive(false);
                re18_1.SetActive(false);
                re17_1.SetActive(false);
                re10.SetActive(false);
                re15.SetActive(false);
                re15_1.SetActive(false);
                re15_2.SetActive(false);
                re17.SetActive(false);
            re17_2.SetActive(false);
                re13.SetActive(false);
                re13_1.SetActive(false);
                re13_2.SetActive(false);
                re13_3.SetActive(false);
                re14.SetActive(false);
                re14_1.SetActive(false);
                re14_2.SetActive(false);
                re12.SetActive(false);
                re12_1.SetActive(false);
                re12_2.SetActive(false);
                re12_3.SetActive(false);
                h2o1.SetActive(false);
                water12.SetActive(false);
                re10.SetActive(false);
                re10_1.SetActive(false);
                re9.SetActive(false);
                re9_1.SetActive(false);
                re8.SetActive(false);
                re8_1.SetActive(false);
                reg7.SetActive(false);
                mgcl2.SetActive(false);
                h2.SetActive(false);
                reg6.SetActive(false);
                fes.SetActive(false);
                reg5.SetActive
                    (false);
                caoh2.SetActive(false);
                reg4.SetActive(false);
                nacl_1.SetActive(false);
                zncl.SetActive(false);
                zncl2.SetActive(false);
                hydrogen.SetActive(false);
                hydrogen1.SetActive(false);
                h2o.SetActive(false);
                water1.SetActive(false);

                cloud.SetActive(false);
                re9_2.SetActive(false);
                water.SetActive(false);
                canvas.SetActive(true);
                canvas1.SetActive(true);
               audioSource.Pause();
                if (target == true)
                {
                    if (but == false)

                    {


                        audioSource.clip = audioClips[currentClipIndex].clip;
                        audioSource.Play();
                        audioplay = false;
                    }
                }

                if (but == true)
                {
                    stopaudio();
                }
                if (but == false)
                {
                    playaudio();
                }
                modelPrefabs[currentModelIndex].SetActive(true);
                modelPrefabs1[currentModelIndex1].SetActive(true);
                
            }
        }
        
    }

    void OnGUI()
    {
        GUIStyle localStyle = new GUIStyle();
        localStyle.normal.textColor = Color.white;
        localStyle.fontSize = 40;
        GUI.Label(new Rect(20, 2200, Screen.width - 20, 30), guiText , localStyle);
    }
    public GameObject canvas;

    // Call this method to make the canvas visible
    public void ShowCanvas()
    {
        canvas.SetActive(true);
    }

    // Call this method to make the canvas invisible
    public void HideCanvas()
    {
        canvas.SetActive(false);
    }
    public GameObject canvas1;
    public void ShowCanvas1()
    {
        canvas1.SetActive(true);
    }

    // Call this method to make the canvas invisible
    public void HideCanvas1()
    {
        canvas1.SetActive(false);
    }
    public AudioSource[] audioClips;
    private int currentClipIndex = 0;
    private AudioSource audioSource;



    public void PlayNextClip()
    {
        if (currentClipIndex > audioClips.Length-2)
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
    private bool audioplay=false; 
    public void stopaudio()
    {
        audioSource.clip = audioClips[currentClipIndex].clip;
        audioSource.Pause();
        audioplay = true;
    }
    public void playaudio()
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

    private bool but = true;
    public GameObject speakon;
    public GameObject speakoff;
  
    public void speaker()
    {

        if (but==true)
        {
            speakoff.SetActive(true); speakon.SetActive(false);
            
            but = false;
         
           
        }
        else
        {
            speakoff.SetActive(false); speakon.SetActive(true);
            
            but = true ;
        }
    }
    bool target=false;
    public void found()
    {
        target = true;
    }
    public void lost()
    {
        target = false;
    }
    public void found1()
    {
        target1 = true;
    }
    public void lost1()
    {
        target1 = false;
    }
}
