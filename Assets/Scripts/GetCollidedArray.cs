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
    private void Start()
    {
         
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
                foreach (int number in SumArray)
                {
                    sw.WriteLine(number);
                }

            }
        }

    }
}
