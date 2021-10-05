using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChange3 : MonoBehaviour
{
    public GameObject Cam3;
    public GameObject Cam4;

    void Start()
    {
        //MainCamera.SetActive(true);
        Cam3.SetActive(true);
        Cam4.SetActive(false);
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Component"))
        {
            //MainCamera.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(true);
            Debug.Log("Cameras Changed ..um 4x!");

        }

    }
}
