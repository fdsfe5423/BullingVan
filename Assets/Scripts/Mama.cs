using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mama : MonoBehaviour
{
    public bool can;
    public bool youMakeZadPol;
    public bool youMakeZadSvet;
    public bool youMakeZadDog;
    public GameObject panel;
    public List<GameObject> gayObject = new List<GameObject>();
    public List<string> textsRU = new List<string>();
    public List<string> textsEN = new List<string>();

    private void Update()
    {
        if (youMakeZadPol)
        {
            gayObject[0].SetActive(false);
        }
        if (youMakeZadSvet)
        {
            gayObject[1].SetActive(false);
        }
        if (youMakeZadDog)
        {
            gayObject[2].SetActive(false);
        }
    }
}
