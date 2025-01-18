using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vadro : MonoBehaviour
{
    public float waterLVL;
    public float MaxWaterLVL;
    public GameObject waterplumb;

    private void Update()
    {
        waterplumb.transform.localPosition = new Vector3(0, waterLVL, 0);
        if(waterLVL > MaxWaterLVL)
        {
            waterLVL = MaxWaterLVL;
        }
        if(waterLVL < 0)
        {
            waterLVL = 0;
        }
        if(gameObject.transform.localRotation.x > 0.95 && gameObject.transform.localRotation.x < 1.05)
        {
            waterLVL -= 0.001f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "voda")
        {
            if(other.gameObject.GetComponent<Sink>().iActive == false)
            {
                return;
            }
            waterLVL += 0.001f;
        }
    }
}
