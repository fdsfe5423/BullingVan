using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shvabra : MonoBehaviour
{
    public bool iwatering;
    public ParticleSystem part;

    private void Start()
    {
        part.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "water" && other.gameObject.GetComponentInParent<Vadro>().waterLVL > 0.3)
        {
            iwatering = true;
            other.gameObject.GetComponentInParent<Vadro>().waterLVL -= 0.3f;
        }
        if (other.gameObject.tag == "Graz" && GameObject.Find("Mam").GetComponent<Mama>().youMakeZadPol && iwatering)
        {
            part.Play();
            Invoke("StopPart", 0.7f);
            other.gameObject.GetComponent<QuestionChexker>().iActive = true;
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    public void StopPart()
    {
        part.Stop();
    }
}
