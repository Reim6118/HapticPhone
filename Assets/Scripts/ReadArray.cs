using System;
using System.IO;
using UnityEngine;

public class ReadArray : MonoBehaviour
{
    /*private float timerself;
    private int[] slicedArray = new int[5];*/
    private static string getArray;
    public static string GetArray
    {
        get => getArray;
    }

    private static bool isreadFilePressed = false;

    public static bool IsReadFilePressed
    {
        get => isreadFilePressed;
        set => isreadFilePressed = value;
    }
    

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        string[] incommingArray = File.ReadAllLines("HapticArray.txt");
        getArray = String.Join("", incommingArray);
        Debug.Log("Read array from file =" + getArray);
        isreadFilePressed = true;
        
        
        
    }
}
