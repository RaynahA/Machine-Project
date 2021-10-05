using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChange4 : MonoBehaviour
{
    public GameObject Cam4;
    public GameObject Cam5;

    void Start()
    {
        //MainCamera.SetActive(true);
        Cam4.SetActive(true);
        Cam5.SetActive(false);
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Component"))
        {
            //MainCamera.SetActive(false);
            Cam4.SetActive(false);
            Cam5.SetActive(true);
            Debug.Log("You made it :)");

        }

    }
}
