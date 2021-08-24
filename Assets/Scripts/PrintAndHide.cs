using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i = 3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{name}:{++i}");
    }
}
