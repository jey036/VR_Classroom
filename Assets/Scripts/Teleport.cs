using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GazeSelect gaze = GameObject.Find("Main Camera").GetComponent<GazeSelect>();
        transform.position = gaze.camPos;
    }
}