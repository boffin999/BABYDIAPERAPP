using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCALESIZE : MonoBehaviour {
    public Slider sliderVal;
    public Text textVal;
	// Use this for initialization
	void Start () {
        sliderVal.value = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
        textVal.text = transform.localScale.x.ToString();
        transform.localScale = new Vector3(sliderVal.value*2, sliderVal.value*2, sliderVal.value*2);
	}
}
