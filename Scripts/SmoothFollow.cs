using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour {
	public GameObject fingerTip;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		  transform.position = Vector3.Lerp(transform.position, new Vector3(fingerTip.transform.position.x ,fingerTip.transform.position.y ,38) , Time.deltaTime * 10);
	}
}
