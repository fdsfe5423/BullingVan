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
    public AudioSource mamOtkazRU;
    public AudioSource mamOtkazEN;
    public bool RUSUB;

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
                if (audio.isPlaying)
                {
                    return;
                }
                if (!hit.collider.gameObject.GetComponent<Mama>().can)
                {
                hit.collider.gameObject.GetComponent<Mama>().panel.SetActive(true);
                hit.collider.GetComponentInParent<Mama>().can = false;
                    text.text = hit.collider.GetComponentInParent<Mama>().nowText;
                    audio.clip = hit.collider.GetComponentInParent<Mama>().nowClip;
                }
                else
                {
                    if(RUSUB)
                    {
                        text.text = "Мама: сына, доделай сначала то что делаешь, а потом поговорим";
                        audio.clip = mamOtkazRU.clip;
                        audio.Play();
                        DisSub();
                    }
                    else
                    {
                        text.text = "Mom: son, finish what you're doing first, and then we'll talk";
                        audio.clip = mamOtkazEN.clip;
                        audio.Play();
                        DisSub();
                    }                  
                }
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
