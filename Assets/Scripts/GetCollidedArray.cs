using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GetCollidedArray : OnCollision
{
    private static float timeGap = 0.6F;
    private static int getArrayLength;
    private static int arraysize = 5;
    private static int count = 0;
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
    private static int a = 1;
    private static int b = 6;
    private static string getArray;


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
            if(ReadArray.GetArray is not null)
            {
                getArray = ReadArray.GetArray;
                if (count == 0)
                { getArrayLength = getArray.Length; count += 1; }
                //Debug.Log("get array = "+ getArray+"length ="+getArray.Length);
            }
            
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
                
                Debug.Log("Array length ="+ getArrayLength);
                Debug.Log("String read from file = " + StringActivatedArray);
                if (b < getArrayLength)
                {
                    a += 5; b += 5;
                    //Debug.Log("a=" + a+"b=" + b +"length ="+getArray.Length);
                }
                else {
                    Debug.Log("Press IsReadFile");
                    ReadArray.IsReadFilePressed = false; }
                stringActivatedArray = getArray[a..b];

                //ReadArray.IsReadFilePressed = false;

            }



            timer = 0;
            Array.Clear(ActivatedArray, 0,arraysize);           // 這裡也要改
            
            
            
        }
        

    }

    

}
