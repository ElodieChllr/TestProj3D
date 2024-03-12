using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoManager : MonoBehaviour
{

    public int photoNumber = 0;

    [Header("triggerPhoto")]
    public GameObject triggerPhoto1;
    public GameObject triggerPhoto2;
    public GameObject triggerPhoto3;
    public GameObject triggerPhoto4;


    void Start()
    {
        
    }

    
    void Update()
    {
        //if(photoNumber >= 4)
        //{
        //    triggerPhoto1.SetActive(false);
        //    triggerPhoto2.SetActive(false);
        //    triggerPhoto3.SetActive(false);
        //    triggerPhoto4.SetActive(false);
        //}

        Debug.Log("I have all the pictures");
    }


    
}
