using System.Net.Sockets;
using UnityEngine;
using System;

public class TcpClientSend : MonoBehaviour
{
    private float timer;
    //private string activatedArray;
    // The IP address of the server to connect to
    
    //private string serverIP = "172.20.10.4";
    private string serverIP = "172.16.230.46";
    // The port number of the server to connect to
    private int serverPort = 6118;

    // The TcpClient object that will be used to connect to the server
    private TcpClient client;

    void Start()
    {
        // Create a new TcpClient object and connect to the server
        client = new TcpClient(serverIP, serverPort);
    }

    void Update()
    {
        timer += Time.deltaTime;
        //activatedArray = GetCollidedArray.StringActivatedArray;
        //Debug.Log("Activated array = " + activatedArray);
        //activatedArray = "0000";

        // Check if the client is still connected to the server
        if (!client.Connected)
        {
            Debug.Log("Disconnected from server");
            return;
        }

        // Get the stream used to read and write data to the server
        NetworkStream stream = client.GetStream();

        // Send data to the server
        if (timer > 0.3 && GetCollidedArray.StringActivatedArray is not null)
        {
            //Debug.Log("Timer in tcp=" + timer);
            byte[] data = System.Text.Encoding.UTF8.GetBytes(GetCollidedArray.StringActivatedArray);
            stream.Write(data, 0, data.Length);
            timer = 0;

            
        }
        

        // Read data from the server
        if (stream.DataAvailable)
        {
            byte[] receivedata = new byte[client.ReceiveBufferSize];
            int bytesRead = stream.Read(receivedata, 0, receivedata.Length);
            string response = System.Text.Encoding.UTF8.GetString(receivedata, 0, bytesRead);
            Debug.Log(response);
        }
    }
}


