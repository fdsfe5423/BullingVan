using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korm : MonoBehaviour
{
    public ParticleSystem particl;
    public bool iActive;
    public BoxCollider sad;
    public GameObject kryt;

    private void Update()
    {
        if (iActive == true)
        {
            sad.enabled = true;
        }
        else if (iActive == false)
        {
            sad.enabled = false;
        }
        if (kryt.transform.rotation.x > 0.3 && !iActive)
        {
            particl.Play();
            iActive = true;
        }
        else if (kryt.transform.rotation.x < 0.3)
        {
            particl.Stop();
            iActive = false;
        }
    }
}
