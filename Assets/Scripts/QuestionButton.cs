using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButton : MonoBehaviour
{
    public int numder;
    public bool RUSUBS;
    public GameObject panel;
    public string nameQuestion;
    public void Tap()
    {
        if(RUSUBS)
        {
            GameObject.Find("MainCamera").GetComponent<UseObject>().text.text = panel.GetComponentInParent<Mama>().textsRU[numder];
            panel.GetComponentInParent<Mama>().nowClip = panel.GetComponentInParent<Mama>().audioSourcesRU[numder].clip;
        }
        else
        {
            panel.GetComponentInParent<Mama>().nowText = panel.GetComponentInParent<Mama>().textsEN[numder];
            panel.GetComponentInParent<Mama>().nowClip = panel.GetComponentInParent<Mama>().audioSourcesEN[numder].clip;
        }
        if (nameQuestion == "pol")
        {
            panel.GetComponentInParent<Mama>().youMakeZadPol = true;
        }
        if (nameQuestion == "svet")
        {
            panel.GetComponentInParent<Mama>().youMakeZadSvet = true;
        }
        if (nameQuestion == "dog")
        {
            panel.GetComponentInParent<Mama>().youMakeZadDog = true;
        }
        panel.GetComponentInParent<Mama>().can = true;
        panel.SetActive(false);
    }
}
