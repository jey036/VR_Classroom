using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Oculus.Avatar;


public class RPointTouch : MonoBehaviour
{

    public OVRInput.Controller controller;
    enum selectionType {type1, type2}; // controlt he current state of selection
    selectionType currenType = selectionType.type1;
    public bool selectState; // Controls the selection type (i.e. ray, or go go, or other method
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
            if(currenType == selectionType.type1)
            {
                // handle type 1 selection here
            }
            else
            {
                // handle type 2 selection here
            }
            // Raycast 
            // detect if chair/desk/whiteboard is targeted
            // no timer on selection
            // "highlight"

            //
        }
        else
        {
            Debug.LogFormat("You're not pointing!!!!!!!!!!");
        }


    }
}