using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassButtonPosition : ButtonPositionUpdate
{
    //protected float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int[] activatedButtons = ActivatedButtons ;
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            Debug.Log("List = " + String.Join("",
            new List<int>(activatedButtons)
            .ConvertAll(i => i.ToString())
            .ToArray()));
            timer  = 0;
        }
    }
}
