using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{

	private CharacterController controller;
	
	public float Gravity = 9.81f;
	public float MoveSpeed = 3.0f;
	public float JumpSpeed = 3.0f; 
	private Vector3 Position;

	private Vector3 Rotation; 
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (controller.isGrounded)
		{
			Position.Set(0,0,MoveSpeed * Input.GetAxis("Vertical"));
			Rotation.Set(0,Input.GetAxis("Horizontal"),0);
			transform.Rotate(Rotation);
			Position = transform.TransformDirection(Position);
			if (Input.GetButton("Jump"))
			{
				Position.y = JumpSpeed;
			}
		}
		Position.y -= Gravity * Time.deltaTime ;
		controller.Move(Position * Time.deltaTime);
	}
}
