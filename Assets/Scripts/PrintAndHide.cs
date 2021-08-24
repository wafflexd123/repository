using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i = 3;
    int random;
    void Start()
    {
        random = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{name}:{++i}");
        if (CompareTag("Red") && i == 100) gameObject.SetActive(false);
        else if (CompareTag("Blue") && i == random) rend.enabled = false;
    }
}
