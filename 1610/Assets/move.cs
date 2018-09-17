using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public CharacterController Character;
	public float Speed;
	public Vector3 RotateSpeed;
	public Vector3 moveSpeed;

	// Update is called once per frame
	void Update ()
	{
		moveSpeed.x = Speed*Input.GetAxis("Horizontal");
		moveSpeed *= Time.deltaTime;

		Character.Move(moveSpeed);

	}
}
