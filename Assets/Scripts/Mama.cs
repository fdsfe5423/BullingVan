using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mama : MonoBehaviour
{
    public GameObject panel;
    public List<bool> boollingVani = new List<bool>();
    public List<GameObject> gayObject = new List<GameObject>();
    public List<string> texts = new List<string>();

    private void Update()
    {
        if (boollingVani[0] == true)
        {
            gayObject[0].SetActive(false);
        }
        if (boollingVani[1] == true)
        {
            gayObject[1].SetActive(false);
        }
        if (boollingVani[2] == true)
        {
            gayObject[2].SetActive(false);
        }
    }
}
