using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;

public class GetCollidedArray : OnCollision
{
    [SerializeField]
    protected float timeGap;
   
    protected static float timer;
    private int counter = 0;
    protected static int[] SumArray = new int[5];  // need to change if array become bigger
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
                SumArray = SumArray.Concat(ActivatedArray).ToArray();
                counter += 1;
            }
            Array.Clear(ActivatedArray, 0, 5);
            Debug.Log("SumArray" + String.Join("",
             new List<int>(SumArray)
             .ConvertAll(i => i.ToString())
             .ToArray()));
            
            timer = 0;
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
