 using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class iska : MonoBehaviour
{
    public float waterLVL;
    public float MaxWaterLVL;
    public GameObject waterplumb;

    private void FixedUpdate()
    {
        waterplumb.transform.localPosition = new Vector3(0, waterLVL, 0);
        if (waterLVL > MaxWaterLVL)
        {
            waterLVL = MaxWaterLVL;
            GameObject.Find("Mam").GetComponent<Mama>().youMakeZadDog = true;
            GameObject.Find("Mam").GetComponent<Mama>().can = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Korm")
        {
            waterLVL += 0.01f;
        }
    }
}
