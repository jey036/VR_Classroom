using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Use to restart the game

public class GazeSelect : MonoBehaviour
{

    public float gazeTimer;
    public Vector3 camPos;
    public bool isLaser;
    public bool hasWeapon;
    public bool cameraMove;
    GameObject prevObj;
    GameObject prefab_cball;

    // Use this for initialization
    void Start()
    {
        gazeTimer = 0.0f;
        camPos = new Vector3(0.0f, 10.0f, 0.0f);
        isLaser = true;
        hasWeapon = false;
        cameraMove = false;
        prevObj = null;
        //prefab_cball = Resources.Load("CannonBall") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(transform.position, transform.forward);
        RaycastHit rayHit;

        GameObject currObj = null;

        // Get the object from raycast
        if (Physics.Raycast(myRay, out rayHit, Mathf.Infinity))
        {
            // TODO Mitch: How to get object pointed to by touch controller?
            currObj = rayHit.collider.gameObject;
        }

        //Debug.LogFormat("You hit {0}!", rayHit.collider.gameObject.name);

        // Check if the current object is hitting the same object
        // as previous gaze
        if (currObj == prevObj && currObj.name == "Floor")
        {
            gazeTimer += Time.deltaTime;
            //Debug.LogFormat("You hit {0}!", currObj.name);
        }
        else
        {
            gazeTimer = 0.0f;
        }

        if (gazeTimer > 2.0f)
        {
            // Look for position on floor and teleport to the position
            if (currObj.name == "Floor")
            {
                camPos = new Vector3(rayHit.point.x, 10.0f, rayHit.point.z);
                prevObj = null;
                gazeTimer = 0.0f;
            }
        }

        prevObj = currObj;
    }

}