using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class DinoControl : MonoBehaviour {

	Animator anim;
	Rigidbody2D rb;
	[SerializeField]
	float jumpForce = 500f;
	float upOrDown;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.gameStopped != true) {
			upOrDown = CrossPlatformInputManager.GetAxisRaw("Vertical");

			anim.SetBool("isJump", false);
			if (upOrDown > 0 && rb.velocity.y == 0)
			{
				anim.SetBool("isJump", true);
				rb.velocity = new Vector2(0, jumpForce);
            }
           

			if (upOrDown < 0 && rb.velocity.y == 0)
				anim.SetBool ("isDown", true);
			else
				anim.SetBool ("isDown", false);
		}
	}
}
