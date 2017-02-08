using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportLock : MonoBehaviour {

	Image toggle;

	// Use this for initialization
	void Start()
	{
		toggle = this.GetComponent<Image>();
	}

	// Update is called once per frame
	void Update()
	{
		GazeSelect gaze = GameObject.Find("Camera").GetComponent<GazeSelect>();

		// Check if laser or not
		if (!gaze.cameraMove)
		{
			toggle.fillAmount = 0.0f;
		}
		else
		{
			toggle.fillAmount = 1.0f;
		}
	}
}