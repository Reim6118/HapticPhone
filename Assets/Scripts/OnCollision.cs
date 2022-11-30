using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
   
    protected static int[] ActivatedArray = new int[5];
    private void OnCollisionEnter2D(Collision2D collision)  //will assign the colided object to collision parameter
    {
        //Debug.Log("hit!:"+collision.gameObject.name);
        switch (collision.gameObject.name)
        {
            case "1-1":
                ActivatedArray[0] = 1;
                break;
            case "1-2":
                ActivatedArray[1] = 1;
                break;
            case "1-3":
                ActivatedArray[2] = 1;
                break;
            case "1-4":
                ActivatedArray[3] = 1;
                break;
            case "1-5":
                ActivatedArray[4] = 1;
                break;


        }
        
    }
    
}
