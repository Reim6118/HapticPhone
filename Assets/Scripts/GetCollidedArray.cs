using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;

public class GetCollidedArray : OnCollision
{
    private static float timeGap = 0.9F;

    private static int arraysize = 5;
    public static float TimeGap
    {
        get => timeGap;
    }
    public static int ArraySize
    {
        get => arraysize;
    }
   
    protected static float timer;
    private int counter = 0;
    protected static int[] SumArray = new int[arraysize];  // need to change if array become bigger
    protected static string collidedString;
    private static string stringSumArray;
    private static string stringActivatedArray;



    public static string StringSumArray 
    {
        get{return stringSumArray;}
       // set { stringSumArray = value;}
    }
    public static string StringActivatedArray
    {
        get { return stringActivatedArray;}
    }


    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= timeGap)
        {
            
            //Debug.Log("Timer" + timer);
            /*collidedString = String.Join("",
             new List<int>(ActivatedArray)
             .ConvertAll(i => i.ToString())
             .ToArray());
            Debug.Log(collidedString);*/
            if (StopButton.isPaused !=true)
            {
                stringActivatedArray = String.Join("",new List<int>(ActivatedArray).ConvertAll(i => i.ToString()).ToArray());
                Debug.Log(StringActivatedArray  +"Timer "+timer);
                SumArray = SumArray.Concat(ActivatedArray).ToArray();   //merge all the informations of blocks
                counter += 1;
            }
            timer = 0;
            Array.Clear(ActivatedArray, 0,arraysize);           // 這裡也要改
            //Debug.Log("SumArray" + String.Join("",
            // new List<int>(SumArray)
            // .ConvertAll(i => i.ToString())
            // .ToArray()));
            
            
        }
        if (counter == 8)
        {
            using(StreamWriter sw = new StreamWriter("HapticArray.txt"))
            {
                stringSumArray = String.Join("",new List<int>(SumArray).ConvertAll(i => i.ToString()).ToArray());
                /*foreach (int number in SumArray)
                {
                    sw.WriteLine(number);
                }*/
                sw.WriteLine(stringSumArray);
            }
        }

    }
}
