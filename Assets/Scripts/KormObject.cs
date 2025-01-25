using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KormObject : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody>().AddRelativeTorque(Random.Range(0, 10000), Random.Range(0, 10000), Random.Range(0, 10000));
        Destroy(gameObject,3f);
    }
}
