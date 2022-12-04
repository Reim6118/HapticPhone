using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class ReadArray : GetCollidedArray
{
    private float timerself;
    private int[] slicedArray = new int[5];
    protected int[] readArray = new int[] { };
    int x = 0;
    int a = 0;
    int b = 5;

    // 應該是要從檔案read全部的array進來，然後切割，每固定秒數讀一次slice出來的array
    /*private void Start()
    {
        //OriginalArray[i] = Convert.ToInt32(sr.ReadLine());
        using (StreamReader sr = new StreamReader("HapticArray.txt"))
        {
            while(sr!= null)
            {
                readArray[x] = Convert.ToInt32(sr.ReadLine());
                Debug.Log("In While");
                x++;
            }
            Debug.Log("stLine = " + String.Join("",
             new List<int>(readArray)
             .ConvertAll(i => i.ToString())
             .ToArray()));
        }
    }*/

    /*void Update()
    {
        timerself += Time.deltaTime;
        if (timerself >= timeGap)
        {
            
            slicedArray = SumArray[a..b];
            Debug.Log("Sliced Array:" + String.Join("",
             new List<int>(slicedArray)
             .ConvertAll(i => i.ToString())
             .ToArray()));
            timerself = 0;
            a += 5;
            b += 5;
            //Array.Clear(slicedArray, 0,5);
        }
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /* Debug.Log("In Collision");
         using (StreamReader sr = new StreamReader("HapticArray.txt"))
         {
             Debug.Log("In using");
             while (!sr.EndOfStream)
             {
                 Debug.Log("In While");
                 readArray[x] = Convert.ToInt32(sr.ReadLine());
                 Debug.Log("stLine = " + String.Join("",
              new List<int>(readArray)
              .ConvertAll(i => i.ToString())
              .ToArray()));
                 x++;
             }

         }*/
        string[] str = File.ReadAllLines("HapticArray.txt");
        Debug.Log("stLine = " + String.Join("",
              new List<string>(str)
              .ConvertAll(i => i.ToString())
              .ToArray()));
    }
}
