using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehaviour : MonoBehaviour
{

	public UnityEvent MouseDown;
	public UnityEvent MouseUp;

	public void OnMouseDown()
	{
		MouseDown.Invoke();
		
	}

	public void OnMouseUp()
	{
		MouseUp.Invoke();
	}
}
