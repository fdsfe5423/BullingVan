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
    public Animator animator;

    public void Tap()
    {
        if(RUSUBS)
        {
            player.GetComponent<UseObject>().text.text = panel.GetComponentInParent<Mama>().textsRU[numder];
            player.GetComponent<UseObject>().audio.clip = panel.GetComponentInParent<Mama>().audioSourcesRU[numder].clip;
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
        if(player.GetComponent<UseObject>().text != null)
        {
            animator.SetBool("IsTalikng", true);
        }
        else
        {
            animator.SetBool("IsTalikng", false);
        }
    }
}
