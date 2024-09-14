using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class panelsequencemcqs : MonoBehaviour
{

    public GameObject[] panels;
    public GameObject panel;

    public GameObject[] obj1;
    public GameObject rightpannel;
    public GameObject quietpannel;
    public GameObject but;

    int i = 1;


    public   void nextpanel()
    {
        panel.SetActive(false);
        panels[0].SetActive(false);
        panels[1].SetActive(false);
        panels[2].SetActive(false);
        panels[3].SetActive(false);
        panels[4].SetActive(false);
        panels[5].SetActive(false);
        panels[6].SetActive(false);
        panels[7].SetActive(false);
        panels[8].SetActive(false);
        panels[9].SetActive(false);
        obj1[0].SetActive(false);
        obj1[1].SetActive(false);
        obj1[2].SetActive(false);
        obj1[3].SetActive(false);
        obj1[4].SetActive(false);
        obj1[5].SetActive(false);
        obj1[6].SetActive(false);
        obj1[7].SetActive(false);
        obj1[8].SetActive(false);
        obj1[9].SetActive(false);
        obj1[10].SetActive(false);
        obj1[11].SetActive(false);
        obj1[12].SetActive(false);
        obj1[13].SetActive(false);
        obj1[14].SetActive(false);
        obj1[15].SetActive(false);
        obj1[16].SetActive(false);
        obj1[17].SetActive(false);

        panels[i].SetActive(true);
        i++;
        if (i >= 10)
        {
            rightpannel.SetActive(false);
            quietpannel.SetActive(true);
            panel.SetActive(false);
            panels[0].SetActive(false);
            panels[1].SetActive(false);
            panels[2].SetActive(false);
            panels[3].SetActive(false);
            panels[4].SetActive(false);
            panels[5].SetActive(false);
            panels[6].SetActive(false);
            panels[7].SetActive(false);
            panels[8].SetActive(false);
            panels[9].SetActive(false);
            but.SetActive(false);
        }
    }
    
        
    public void active_wrong()
    {
        panel.SetActive(true);
        rightpannel.SetActive(false);
        obj1[15].SetActive(false);
        obj1[16].SetActive(false);
        obj1[17].SetActive(false);
        obj1[0].SetActive(false);
        obj1[1].SetActive(false);
        obj1[2].SetActive(false);
        obj1[3].SetActive(false);
        obj1[4].SetActive(false);
        obj1[5].SetActive(false);
        obj1[6].SetActive(false);
        obj1[7].SetActive(false);
        obj1[8].SetActive(false);
        obj1[9].SetActive(false);
        obj1[10].SetActive(false);
        obj1[11].SetActive(false);
        obj1[12].SetActive(false);
        obj1[13].SetActive(false);
        obj1[14].SetActive(false);


    }
    public void firstsolution()
    {
        if (target)
        {
            obj1[0].SetActive(false);
            panel.SetActive(false);
            obj1[1].SetActive(true);
            obj1[2].SetActive(true);
            obj1[3].SetActive(true);
            obj1[4].SetActive(false);
            obj1[5].SetActive(false);
            obj1[6].SetActive(false);
            obj1[7].SetActive(false);
            obj1[8].SetActive(false);
            obj1[9].SetActive(false);
            obj1[10].SetActive(false);
            obj1[11].SetActive(false);
            obj1[12].SetActive(false);
            obj1[13].SetActive(false);
            obj1[14].SetActive(false);
            obj1[15].SetActive(false);
            obj1[16].SetActive(false);
            obj1[17].SetActive(false);
        }
    }
    public void secondsolution()
    {
        if (target)
        {
            obj1[0].SetActive(false);
            panel.SetActive(false);
            obj1[4].SetActive(true);
            obj1[5].SetActive(true);
            obj1[6].SetActive(true);
            obj1[1].SetActive(false);
            obj1[2].SetActive(false);
            obj1[3].SetActive(false);
            obj1[7].SetActive(false);
            obj1[8].SetActive(false);
            obj1[9].SetActive(false);
            obj1[10].SetActive(false);
            obj1[11].SetActive(false);
            obj1[12].SetActive(false);
            obj1[13].SetActive(false);
            obj1[14].SetActive(false);
            obj1[15].SetActive(false);
            obj1[16].SetActive(false);
            obj1[17].SetActive(false);
        }

    }
    public void thirdsolution()
    {
        if (target)
        {
            obj1[0].SetActive(false);
            panel.SetActive(false);
            obj1[7].SetActive(true);
            obj1[8].SetActive(true);
            obj1[9].SetActive(true);
            obj1[1].SetActive(false);
            obj1[2].SetActive(false);
            obj1[3].SetActive(false);
            obj1[4].SetActive(false);
            obj1[5].SetActive(false);
            obj1[6].SetActive(false);
            obj1[10].SetActive(false);
            obj1[11].SetActive(false);
            obj1[12].SetActive(false);
            obj1[13].SetActive(false);
            obj1[14].SetActive(false);
            obj1[15].SetActive(false);
            obj1[16].SetActive(false);
            obj1[17].SetActive(false);
        }
    }
    public void fourthsolution()
    {
        if (target)
        {
            panel.SetActive(false);
            obj1[0].SetActive(true);
            obj1[1].SetActive(false);
            obj1[2].SetActive(false);
            obj1[3].SetActive(false);
            obj1[4].SetActive(false);
            obj1[5].SetActive(false);
            obj1[6].SetActive(false);
            obj1[7].SetActive(false);
            obj1[8].SetActive(false);
            obj1[9].SetActive(false);
            obj1[10].SetActive(false);
            obj1[11].SetActive(false);
            obj1[12].SetActive(false);
            obj1[13].SetActive(false);
            obj1[14].SetActive(false);
            obj1[15].SetActive(false);
            obj1[16].SetActive(false);
            obj1[17].SetActive(false);
        }
    }
    public void fivesolution()
    {
        if (target)
        {
            panel.SetActive(false);
            obj1[10].SetActive(true);
            obj1[0].SetActive(false);
            obj1[1].SetActive(false);
            obj1[2].SetActive(false);
            obj1[3].SetActive(false);
            obj1[4].SetActive(false);
            obj1[5].SetActive(false);
            obj1[6].SetActive(false);
            obj1[7].SetActive(false);
            obj1[8].SetActive(false);
            obj1[9].SetActive(false);
            obj1[11].SetActive(false);
            obj1[12].SetActive(false);
            obj1[13].SetActive(false);
            obj1[14].SetActive(false);
            obj1[15].SetActive(false);
            obj1[16].SetActive(false);
            obj1[17].SetActive(false);
        }
    }
    public void sixsolution()
    {
        if (target)
        {
            panel.SetActive(false);
            obj1[11].SetActive(true);
            obj1[0].SetActive(false);
            obj1[1].SetActive(false);
            obj1[2].SetActive(false);
            obj1[3].SetActive(false);
            obj1[4].SetActive(false);
            obj1[5].SetActive(false);
            obj1[6].SetActive(false);
            obj1[7].SetActive(false);
            obj1[8].SetActive(false);
            obj1[9].SetActive(false);
            obj1[10].SetActive(false);
            obj1[12].SetActive(false);
            obj1[13].SetActive(false);
            obj1[14].SetActive(false);
            obj1[15].SetActive(false);
            obj1[16].SetActive(false);
            obj1[17].SetActive(false);
        }
    }
    public void sevensolution()
    {
        if (target)
        {
            panel.SetActive(false);
            obj1[12].SetActive(true);
            obj1[0].SetActive(false);
            obj1[1].SetActive(false);
            obj1[2].SetActive(false);
            obj1[3].SetActive(false);
            obj1[4].SetActive(false);
            obj1[5].SetActive(false);
            obj1[6].SetActive(false);
            obj1[7].SetActive(false);
            obj1[8].SetActive(false);
            obj1[9].SetActive(false);
            obj1[10].SetActive(false);
            obj1[11].SetActive(false);
            obj1[13].SetActive(false);
            obj1[14].SetActive(false);
            obj1[15].SetActive(false);
            obj1[16].SetActive(false);
            obj1[17].SetActive(false);
        }
    }
    public void eightsolution()
    {
        if (target)
        {
            panel.SetActive(false);
            obj1[13].SetActive(true);
            obj1[0].SetActive(false);
            obj1[1].SetActive(false);
            obj1[2].SetActive(false);
            obj1[3].SetActive(false);
            obj1[4].SetActive(false);
            obj1[5].SetActive(false);
            obj1[6].SetActive(false);
            obj1[7].SetActive(false);
            obj1[8].SetActive(false);
            obj1[9].SetActive(false);
            obj1[10].SetActive(false);
            obj1[11].SetActive(false);
            obj1[12].SetActive(false);
            obj1[14].SetActive(false);
            obj1[15].SetActive(false);
            obj1[16].SetActive(false);
            obj1[17].SetActive(false);
        }
    }
    public void ninesolution()
    {
        if (target)
        {
            panel.SetActive(false);
            obj1[14].SetActive(true);
            obj1[0].SetActive(false);
            obj1[1].SetActive(false);
            obj1[2].SetActive(false);
            obj1[3].SetActive(false);
            obj1[4].SetActive(false);
            obj1[5].SetActive(false);
            obj1[6].SetActive(false);
            obj1[7].SetActive(false);
            obj1[8].SetActive(false);
            obj1[9].SetActive(false);
            obj1[10].SetActive(false);
            obj1[11].SetActive(false);
            obj1[12].SetActive(false);
            obj1[13].SetActive(false);
            obj1[15].SetActive(false);
            obj1[16].SetActive(false);
            obj1[17].SetActive(false);
        }
    }
    public void tensolution()
    {
        if (target)
        {
            panel.SetActive(false);
            obj1[15].SetActive(true);
            obj1[16].SetActive(true);
            obj1[17].SetActive(true);
            obj1[0].SetActive(false);
            obj1[1].SetActive(false);
            obj1[2].SetActive(false);
            obj1[3].SetActive(false);
            obj1[4].SetActive(false);
            obj1[5].SetActive(false);
            obj1[6].SetActive(false);
            obj1[7].SetActive(false);
            obj1[8].SetActive(false);
            obj1[9].SetActive(false);
            obj1[10].SetActive(false);
            obj1[11].SetActive(false);
            obj1[12].SetActive(false);
            obj1[13].SetActive(false);
            obj1[14].SetActive(false);

        }
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("registeration");
    }
    public void activeright()
    {
        rightpannel.SetActive(true);
        panel.SetActive(false);
        target = false;
    }
    public void Umactive()
    {
        rightpannel.SetActive(false);
        panel.SetActive(false);
        target = true;
    }
    private bool target=false;
    
}

   


