using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pLAB_DimRotation : MonoBehaviour {

	public  Animator animator;


	public Transform point;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DimRotate(float aValue){
		if(!animator.GetCurrentAnimatorStateInfo(0).IsName("dim"))
		{
			animator.Play ("dim");

			if (aValue < 0) {
				Invoke ("RotateToLeft", 0.5f);
			} else {
				Invoke ("RotateToRight", 0.5f);
			}
		}
			
	}

	public void RotateToLeft(){
		transform.RotateAround (point.position, Vector3.up, -45f);
	}

	public void RotateToRight(){
		transform.RotateAround (point.position, Vector3.up, 45f);
	}
}
