using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoControl : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer vidPlayer;
    protected double currentTime;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
       
                
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            GetCurrentTime();
            timer = 0;
        }
    }
    
    void GetCurrentTime()
    {
        if (vidPlayer != null)
        {
            currentTime = vidPlayer.time;
            //Debug.Log("Current Time:" + currentTime);
        }
    }
}
