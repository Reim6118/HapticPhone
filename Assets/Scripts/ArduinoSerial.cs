/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoSerial : MonoBehaviour
{
    SerialPort serial = new SerialPort("COM3");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
using UnityEngine;
using System.IO.Ports;
public class ArduinoSerial : GetCollidedArray
{
    SerialPort sp;
    float next_time; int ii = 0;
    // Use this for initialization
    void Start()
    {
        string the_com = "";
        next_time = Time.time;

        foreach (string mysps in SerialPort.GetPortNames())
        {
            print(mysps);
            if (mysps != "COM1") { the_com = mysps; break; }
        }
        sp = new SerialPort("\\\\.\\" + the_com, 9600);
        if (!sp.IsOpen)
        {
            print("Opening " + the_com + ", baud 9600");
            sp.Open();
            sp.ReadTimeout = 100;
            sp.Handshake = Handshake.None;
            if (sp.IsOpen) { print("Open"); }
        }
    }
    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Timer in child=" + timer);
        if (timer >= 0.9)
        {
            if (!sp.IsOpen)
            {
                sp.Open();
                print("opened sp");
            }
            if (sp.IsOpen)
            {
                print("Writing " + collidedString);
                sp.Write(collidedString);
            }
            
        }
    }
}