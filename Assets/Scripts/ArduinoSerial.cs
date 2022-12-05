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
public class ArduinoSerial : MonoBehaviour
{
    SerialPort sp;
    float next_time; int ii = 0;
    private float timer;
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
        sp = new SerialPort("\\\\.\\" + the_com, 115200);
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
        timer += Time.deltaTime;
       // Debug.Log("Timer in child=" + timer);
        if (timer >= 2)
        {
            if (!sp.IsOpen)
            {
                sp.Open();
                print("opened sp");
            }
            if (sp.IsOpen)
            {
                print("Writing " + GetCollidedArray.StringActivatedArray + "Timer = "+timer);
                sp.Write(GetCollidedArray.StringActivatedArray);
            }
            timer = 0;
        }
    }
}