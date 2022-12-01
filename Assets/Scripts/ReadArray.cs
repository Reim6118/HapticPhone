using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ReadArray : GetCollidedArray
{
    private float timerself;
    private int[] slicedArray = new int[5];
    int a=0;
    int b = 5;

    // 應該是要從檔案read全部的array進來，然後切割，每固定秒數讀一次slice出來的array
    private void Start()
    {
        
    }

    void Update()
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
    }
}
