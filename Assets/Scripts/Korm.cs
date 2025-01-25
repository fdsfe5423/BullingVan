using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korm : MonoBehaviour
{
    public GameObject KORM;
    public GameObject point;

    private void Update()
    {
        if (gameObject.transform.rotation.x > 0.3)
        {
            Instantiate(KORM, point.transform.position, Quaternion.identity);
        }
    }
}
