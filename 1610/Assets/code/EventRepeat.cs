using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventRepeat : MonoBehaviour
{
	public float Seconds = 2;
	public UnityEvent[] OnRepeat;
	public UnityEvent OnRepeatTwo;

	private int i = 0;
	// Use this for initialization
	IEnumerator Start () {
		while (true)
		{
			yield return new WaitForSeconds(Seconds);

			OnRepeat[i].Invoke();
			if (i < OnRepeat.Length - 1)
			{
				i++;

			}
			else
			{
				i = 0;
			}
		}
	}
	
	

}
