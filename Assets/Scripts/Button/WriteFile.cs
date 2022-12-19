using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WriteFile : GetCollidedArray
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string filepath = Path.Combine(Application.persistentDataPath, "HapticArray.txt");
        using (StreamWriter sw = new StreamWriter(filepath))
        {
            
            Debug.Log("Writting file...");
            sw.WriteLine(StringSumArray);
            Debug.Log("Done Writting");
        }
    }
    
}
//stringSumArray = String.Join("", new List<int>(SumArray).ConvertAll(i => i.ToString()).ToArray());
/*foreach (int number in SumArray)
{
    sw.WriteLine(number);
}*/