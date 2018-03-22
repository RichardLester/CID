using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Click : MonoBehaviour {
	public GameObject theCube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("FingerTip")){
			theCube.SetActive(true);
			StartCoroutine(TurnCubeOff());
		}
	}

	public void ClickMe(){
		theCube.SetActive(true);
		StartCoroutine(TurnCubeOff());

	}

	IEnumerator TurnCubeOff(){
		yield return new WaitForSeconds(5);
		theCube.SetActive(false);
	}
	
}
