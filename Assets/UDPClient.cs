using UnityEngine;
using System.Net.Sockets;
using System.Text;
using UnityEngine.VR;
using System;

public class UDPClient : MonoBehaviour
{
    // broadcast address
    private string host = "133.10.79.255";
    private int port = 61000;
    private UdpClient client;
    


    void Start()
    {
        client = new UdpClient();
        client.Connect(host, port);
        
    }


    float time = 0.0f;

    //60Hzでudp通信
    void Update()
    {

        time += Time.deltaTime; //時間管理

        //シーン１
        if (Input.GetKey(KeyCode.A)) { 
            Debug.Log("パケット1送信");
            byte[] dgram1 = Encoding.UTF8.GetBytes("1");
            client.Send(dgram1, dgram1.Length);
        }

       

    }

}