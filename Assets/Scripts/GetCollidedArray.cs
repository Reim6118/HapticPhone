using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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
    private int a = 0, b = 5;



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
            
            
            if (StopButton.isPaused !=true && ReadArray.IsReadFilePressed != true)
            {
                stringActivatedArray = String.Join("",new List<int>(ActivatedArray).ConvertAll(i => i.ToString()).ToArray());
                //Debug.Log(StringActivatedArray  +"Timer "+timer);
                SumArray = SumArray.Concat(ActivatedArray).ToArray();   //merge all the informations of blocks
                stringSumArray = String.Join("", new List<int>(SumArray).ConvertAll(i => i.ToString()).ToArray());

                counter += 1;
            }

            
            if (StopButton.isPaused != true && ReadArray.IsReadFilePressed == true)
            {
                string getArray = ReadArray.GetArray;
                
                stringActivatedArray = getArray[a..b];
                if (b < getArray.Length)
                { a += 5; b += 5; }
                else { ReadArray.IsReadFilePressed = false; }
                
                //ReadArray.IsReadFilePressed = false;

            }

           

            timer = 0;
            Array.Clear(ActivatedArray, 0,arraysize);           // 這裡也要改
            
            
            
        }
        

    }

    

}
