using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMoveScript : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Cam2;
    //public GameObject Cam3;

    void Start()
    {
        MainCamera.SetActive(true);
        Cam2.SetActive(false);
        //Cam3.SetActive(false);
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Component"))
        {
            MainCamera.SetActive(false);
            Cam2.SetActive(true);
            //Cam3.SetActive(false);
            Debug.Log("Cameras Changed!");

        }
        
    }
}
