using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using TMPro;
using static UnityEngine.Rendering.DebugUI;

public class UseObject : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int distance;
    public InputActionProperty action;
    public AudioSource audio;
    public AudioSource mamOtkaz;

    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward * distance);
        Debug.DrawRay(transform.position, transform.forward * distance, Color.white);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            float isTap = action.action.ReadValue<float>();
            if(hit.collider.gameObject.GetComponent<Mama>() &&isTap > 0.5)
            {
                if (!hit.collider.gameObject.GetComponent<Mama>().can)
                {
                hit.collider.gameObject.GetComponent<Mama>().panel.SetActive(true);
                hit.collider.GetComponentInParent<Mama>().can = false;
                }
                else
                {
                    text.text = "Мама: сына, доделай сначала то что делаешь, а потом поговорим";
                    mamOtkaz.Play();
                }
            }
            if(hit.collider.gameObject.GetComponent<UsedObject>() && hit.collider.gameObject.GetComponent<UsedObject>().youCanActiveMi && isTap > 0.5)
            {
            if(audio.isPlaying)
            {
                return;
            }
                hit.collider.gameObject.GetComponent<UsedObject>().youCanActiveMi = false;
                audio.clip = hit.collider.gameObject.GetComponent<UsedObject>().audioRU.clip;
                audio.Play();
                text.text = hit.collider.gameObject.GetComponent<UsedObject>().subTextRU;
                DisSub();
            }
        }
    }
    public void DisSub()
    {
        if (audio.isPlaying == false)
        {
            Invoke("DisingingSub", 2f);
        }
        else
        {
            Invoke("DisSub", 0.2f);
        }
    }
    public void DisingingSub()
    {
        text.text = null;
    }
}
