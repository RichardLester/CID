using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class BtnControl : MonoBehaviour {
	public Sprite btnUp;
	public Sprite btnOver;
	private SpriteRenderer spriteRenderer; 

	public GameObject pointer;
	// Use this for initialization
	public bool isHit = false;
	bool countingDown = false;
	public UnityEvent onExecute;
	IEnumerator co;
	public float graceTime;
	public float clickTime;

	bool canClick = false;
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	
	public void StartRecievedClick () {
		//print("I am clicked");
		if(isHit){
			spriteRenderer.sprite = btnOver;
			canClick = true;
			//countingDown = true;
			//co = StartClick();
			//StartCoroutine(co);
		}else{
			spriteRenderer.sprite = btnUp;
			canClick = false;
			//countingDown = false;
			//StopCoroutine(co);
			
			//StopClick();
		}
	}

	public IEnumerator StartClick()
	{
		if(countingDown){
			yield return new WaitForSeconds(graceTime);
			print("Start countdown");
			pointer.GetComponent<Animation>().Play();
			yield return new WaitForSeconds(clickTime);
			//print("Clicked");
		}
		
	}
	void StopClick(){
		pointer.GetComponent<Animation>().Rewind();
		pointer.GetComponent<Animation>().Play();
		pointer.GetComponent<Animation>().Stop();
		
	}
}
