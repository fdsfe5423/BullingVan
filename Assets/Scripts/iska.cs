 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iska : MonoBehaviour
{
    public float waterLVL;
    public float MaxWaterLVL;
    public GameObject waterplumb;

    private void FixedUpdate()
    {
        waterplumb.transform.localPosition = new Vector3(0, 0,waterLVL/100);
        if (waterLVL > MaxWaterLVL)
        {
            waterLVL = MaxWaterLVL;
            GameObject.Find("Mam").GetComponent<Mama>().can = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Korm" && GameObject.Find("Mam").GetComponent<Mama>().youMakeZadDog)
        {
            waterLVL += 0.0005f;
        }
    }
}
