using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Vadro : MonoBehaviour
{
    public ParticleSystem part;
    public float waterLVL;
    public float MaxWaterLVL;
    public GameObject waterplumb;
    public GameObject pivot;

    private void Start()
    {
        part.Stop();
    }

    private void FixedUpdate()
    {
        waterplumb.transform.localPosition = new Vector3(0, 0,waterLVL/111);
        if(waterLVL > MaxWaterLVL)
        {
            waterLVL = MaxWaterLVL;
        }
        if(waterLVL < 0)
        {
            part.Stop();
            waterLVL = 0;
        }
        if (waterLVL > 0)
        {
            if (pivot.transform.localRotation.x < -0.98 && pivot.transform.localRotation.x > -1.02 || pivot.transform.localRotation.x > 0.98 && pivot.transform.localRotation.x < 1.02 || pivot.transform.localRotation.z < -0.98 && pivot.transform.localRotation.z > -1.02 || pivot.transform.localRotation.z > 0.98 && pivot.transform.localRotation.z < 1.02)
            {
                StartCoroutine(Sliv());
                waterLVL -= 0.01f;
            }
            else
            {
                part.Stop();
            }
        }
    }

    IEnumerator Sliv()
    {
        if(!part.isPlaying)
        {
            part.Play();
        }
        yield return new WaitForSeconds(1);
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
