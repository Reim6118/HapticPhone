using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GetCollidedArray : OnCollision
{
    [SerializeField]
    private float timeGap;
    protected static float timer;
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
            collidedString = String.Join("",
             new List<int>(ActivatedArray)
             .ConvertAll(i => i.ToString())
             .ToArray());
            Debug.Log(collidedString);
            Array.Clear(ActivatedArray, 0, 5);
            timer = 0;
        }
    }
}
