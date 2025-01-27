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
                if (!hit.collider.gameObject.GetComponent<Mama>().can)
                {
                hit.collider.gameObject.GetComponent<Mama>().panel.SetActive(true);
                hit.collider.GetComponentInParent<Mama>().can = false;
                    text.text = hit.collider.GetComponentInParent<Mama>().nowText;
                }
                else
                {
                    if(RUSUB)
                    {
                        text.text = "Мама: сына, доделай сначала то что делаешь, а потом поговорим";
                        DisSub();
                    }
                    else
                    {
                        text.text = "Mom: son, finish what you're doing first, and then we'll talk";
                        DisSub();
                    }                  
                }
            }
        }
    }
    public void DisSub()
    {
            Invoke("DisingingSub", 5f);     
    }
    public void DisingingSub()
    {
        text.text = null;
    }
}
