using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
   
    protected static int[] ActivatedArray = new int[GetCollidedArray.ArraySize]; //array大小改這裡

    //private void Start()
    //{
    //    Array.Clear(ActivatedArray, 0, ActivatedArray.Length);
    //}
    private void OnCollisionEnter2D(Collision2D collision)  //will assign the colided object to collision parameter
    {
        Debug.Log("hit!:"+collision.gameObject.name);
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
            //case "2-1":
            //    ActivatedArray[5] = 1;
            //    break;
            //case "2-2":
            //    ActivatedArray[6] = 1;
            //    break;
            //case "2-3":
            //    ActivatedArray[7] = 1;
            //    break;
            //case "2-4":
            //    ActivatedArray[8] = 1;
            //    break;
            //case "2-5":
            //    ActivatedArray[9] = 1;
            //    break;



        }
        
    }
    
}
