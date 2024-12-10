using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{

    public int frameNum;

    // Start is called before the first frame update
    void Start()
    {

        frameNum = 1;
        Debug.Log("I was told to Start" + this.gameObject.name);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Frame #{0}: Update Time: {1}", frameNum, Time.time);
        Debug.Log("Frame " + frameNum + "Update at time: " + Time.time);
        frameNum = frameNum + 1;

    }
}
