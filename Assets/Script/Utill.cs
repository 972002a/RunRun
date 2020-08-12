using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utill : MonoBehaviour
{
  

   
    public static Utill Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }



    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        

    }

    void Update()
    {
        
    }
}
