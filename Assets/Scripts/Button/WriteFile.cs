using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WriteFile : GetCollidedArray
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        using (StreamWriter sw = new StreamWriter("HapticArray.txt"))
        {
            //stringSumArray = String.Join("", new List<int>(SumArray).ConvertAll(i => i.ToString()).ToArray());
            /*foreach (int number in SumArray)
            {
                sw.WriteLine(number);
            }*/
            Debug.Log("Writting file...");
            sw.WriteLine(StringSumArray);
            Debug.Log("Done Writting");
        }
    }
    
}
