using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using TMPro;

public class UseObject : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int distance;
    public InputActionProperty action;
    public AudioSource audio;

    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward * distance);
        Debug.DrawRay(transform.position, transform.forward * distance, Color.white);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if(audio.isPlaying)
            {
                return;
            }
            float isTap = action.action.ReadValue<float>();
            if(hit.collider.gameObject.GetComponent<UsedObject>() && hit.collider.gameObject.GetComponent<UsedObject>().youCanActiveMi && isTap > 0.5)
            {
                hit.collider.gameObject.GetComponent<UsedObject>().youCanActiveMi = false;
                audio.clip = hit.collider.gameObject.GetComponent<UsedObject>().audio.clip;
                audio.Play();
                text.text = hit.collider.gameObject.GetComponent<UsedObject>().subText;
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
