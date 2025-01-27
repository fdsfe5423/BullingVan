using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ICanOutOfRoom : MonoBehaviour
{
    public GameObject text;
    public GameObject rb;
    public int countCloth;

    private void Update()
    {
       if(countCloth == 6)
        {
            text.SetActive(false);
            rb.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!other.gameObject.GetComponent<Clothes>().iActive)
        {
            countCloth++;
            other.gameObject.GetComponent<Clothes>().iActive = true;
        }
    }
}
