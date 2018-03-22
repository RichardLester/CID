using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {
	RaycastHit hit;
	float theDistance;
	GameObject theBtn;
	GameObject tempBtn;
	bool canTurnOffBtn;

	public bool canCastRay = true;

	public GameObject bone1;
    public GameObject bone2;
    public GameObject bone3;
	void Update () {
		// Debug Raycast
		Vector3 forward = transform.TransformDirection(Vector3.forward) *15;
		Debug.DrawRay(transform.position,forward,Color.green);

		// Work out angles between bones for click
		float AngleDiff = Quaternion.Angle(bone1.transform.localRotation, bone2.transform.localRotation);
        float AngleDiff2 = Quaternion.Angle(bone2.transform.localRotation, bone3.transform.localRotation);

		if(Physics.Raycast(transform.position,(forward), out hit)){
			
				canCastRay = false;
				canTurnOffBtn = true;

				theBtn = hit.collider.gameObject;
				tempBtn = theBtn.gameObject;

				theBtn.GetComponent<BtnControl>().isHit = true;
				theBtn.GetComponent<BtnControl>().StartRecievedClick();

				print("casting ray");

				
		}else{
			if(canTurnOffBtn){
				canCastRay = true;
				tempBtn.GetComponent<BtnControl>().isHit = false;
				theBtn.GetComponent<BtnControl>().StartRecievedClick();
				canTurnOffBtn = false;

				//print("casting ray Stopped");
			}
		}

		if (canCastRay && AngleDiff + AngleDiff2 >= 70){
			if(tempBtn){
				theBtn.GetComponent<BtnControl>().StartClick();
			}	
		}
	}
}
