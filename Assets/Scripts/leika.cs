using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leika : MonoBehaviour
{
    public bool iActive;
    public ParticleSystem part;
    public float waterLVL;
    public float MaxWaterLVL;
    public GameObject waterplumb;
    public GameObject kryt;

    private void Start()
    {
        part.Stop();
    }

    private void FixedUpdate()
    {
        waterplumb.transform.localPosition = new Vector3(0, -0.0035f, waterLVL / 80);
        if (waterLVL > MaxWaterLVL)
        {
            waterLVL = MaxWaterLVL;
        }
        if (waterLVL < 0)
        {
            part.Stop();
            waterLVL = 0;
        }
        if (waterLVL > 0)
        {
            if (kryt.transform.localRotation.x > 0.5 && kryt.transform.localRotation.x < 0.75)
            { 
                StartCoroutine(Sliv());
                waterLVL -= 0.0005f;
            }
            else
            {
                part.Stop();
                iActive = false;
            }
        }
    }

    IEnumerator Sliv()
    {
        if (!part.isPlaying)
        {
            iActive = true;
            part.Play();
        }
        yield return new WaitForSeconds(1);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "voda")
        {
            if (other.gameObject.GetComponent<Sink>().iActive == false)
            {
                return;
            }
            waterLVL += 0.001f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sveti" && GameObject.Find("Mam").GetComponent<Mama>().youMakeZadSvet && iActive)
        {
            other.gameObject.GetComponent<QuestionChexker>().iActive = true;
        }
    }
}
