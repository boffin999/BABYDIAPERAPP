using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class hideCarBody : MonoBehaviour {
	public Slider crossingCarPlaneSlider;
	public Slider rotatingCarSlider;
	public Slider scalingCarSlider;
	public GameObject crossPlane;

	public GameObject OriginalCarBody;
	public GameObject MergedCarBody;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.localEulerAngles = new Vector3 (0, gameObject.transform.localEulerAngles.y + rotatingCarSlider.value * Time.deltaTime, 0);
		gameObject.transform.localScale = new Vector3 (scalingCarSlider.value,scalingCarSlider.value,scalingCarSlider.value);
		crossPlane.transform.localPosition = new Vector3 (0, crossingCarPlaneSlider.value, 0);
		if (crossingCarPlaneSlider.value > 2) {
			if (OriginalCarBody.activeSelf == false) 
				OriginalCarBody.SetActive (true);
			if (MergedCarBody.activeSelf == true) 
				MergedCarBody.SetActive (false);
			
		} else {
				if (OriginalCarBody.activeSelf == true)
					OriginalCarBody.SetActive (false);
				if (MergedCarBody.activeSelf == false)
					MergedCarBody.SetActive (true);
			}
		}
}
