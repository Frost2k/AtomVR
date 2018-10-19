using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMol : MonoBehaviour {

    GameObject Hemoglobin;

    void Start()
    {
        Hemoglobin = GameObject.Find("Hemoglobin");
        Hemoglobin.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Hemoglobin.SetActive(true);
        }
    }
}