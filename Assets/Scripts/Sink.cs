using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sink : MonoBehaviour
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
        if (kryt.transform.rotation.y > 0.3 && !iActive)
        {
            particl.Play();
            iActive = true;
        }
        else if (kryt.transform.rotation.y < 0.3)
        {
            particl.Stop();
            iActive = false;
        }
    }
}
    


