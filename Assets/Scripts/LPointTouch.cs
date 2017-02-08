using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Oculus.Avatar;

public class LPointTouch : MonoBehaviour
{

    public OVRInput.Controller controller;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.localPosition = OVRInput.GetLocalControllerPosition(controller);
        // transform.localRotation = OVRInput.GetLocalControllerRotation(controller);


        Debug.LogFormat(OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger).ToString());
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) >= 0.5f)
        {
            // Raycast 
            // detect if floor is targeted
            // teleport after # of seconds
        }
        else
        {
            Debug.LogFormat("You're not pointing!!!!!!!!!!");
        }


    }
}