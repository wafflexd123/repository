using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;

    void Start()
    {
        Instantiate(redObj, Vector3.right * 2, Quaternion.identity);
        Instantiate(blueObj, Vector3.left * 2, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
