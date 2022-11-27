using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;


public class ButtonPositionUpdate : MonoBehaviour
{
    public int[] ActivatedButtons = new int[5];
    public static string ButtonString;
    //public string ButtonsString { get { return buttonstring; } set { buttonstring = value; } }
    protected static float timer;
    [SerializeField]
    private Button[] buttons;
  /*1   2   3   4   5
    6   7   8   9   10*/
    void Start()
    {
        //Debug.Log(ActivatedButtons);
    }
    public void OnButtonClick(int Id)
    {
        
        ActivatedButtons[Id] = 1;
        
        
        /*if (ActivatedButtons[Id] > 1)
        {
            ActivatedButtons[Id] = 0;
        }*/
        
       // Debug.Log(ActivatedButtons[2]);
       /* Debug.Log("List = " + String.Join("",
            new List<int>(ActivatedButtons)
            .ConvertAll(i => i.ToString())
            .ToArray()));*/
    }

    void Update()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            //Debug.Log(buttons[i]);
            //Debug.Log(buttons.Length);
            int copy = i;       //Closure problem
            
            buttons[copy].onClick.AddListener(() => OnButtonClick(copy));
            
           // buttons[copy].onClick.AddListener(delegate { OnButtonClick(copy); });
        }
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            ButtonString = String.Join("",new List<int>(ActivatedButtons).ConvertAll(i => i.ToString()).ToArray());
            Debug.Log("List = " + ButtonString);
            timer = 0;
            Array.Clear(ActivatedButtons, 0, 5);
        }
    }
}
