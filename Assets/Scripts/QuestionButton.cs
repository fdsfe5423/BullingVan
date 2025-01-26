using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButton : MonoBehaviour
{
    public int numder;
    public bool RUSUBS;
    public GameObject panel;
    public string nameQuestion;
    public GameObject player;

    public void Tap()
    {
        if(RUSUBS)
        {
            player.GetComponent<UseObject>().text.text = panel.GetComponentInParent<Mama>().textsRU[numder];
            player.GetComponent<UseObject>().audio.clip = panel.GetComponentInParent<Mama>().audioSourcesRU[numder].clip;
            player.GetComponent<UseObject>().audio.Play();
            player.GetComponent<UseObject>().DisSub();
        }
        else
        {
            player.GetComponent<UseObject>().text.text = panel.GetComponentInParent<Mama>().textsEN[numder];
            player.GetComponent<UseObject>().audio.clip = panel.GetComponentInParent<Mama>().audioSourcesEN[numder].clip;
            player.GetComponent<UseObject>().audio.Play();
            player.GetComponent<UseObject>().DisSub();
        }
        panel.GetComponentInParent<Mama>().can = true;
        panel.SetActive(false);
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
    }
}
