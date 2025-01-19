using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButton : MonoBehaviour
{
    public GameObject panel;
    public string nameQuestion;
    public void Tap()
    {
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
