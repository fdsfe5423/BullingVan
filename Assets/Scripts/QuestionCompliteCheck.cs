using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionCompliteCheck : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<QuestionChexker>().iActive)
        {
            Invoke("Complite", 0.5f);
        }
        else
        {
            CancelInvoke("Complite");
        }
    }
    public void Complite()
    {
        GameObject.Find("Mam").GetComponent<Mama>().can = false;
    }
}
