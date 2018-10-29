using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwtichStatements : MonoBehaviour
{
	public GameStates.States GameState;

	public UnityEvent Starting, Loading, Playing, Ending, Death;
	// Update is called once per frame
	void Update () {
		switch (GameState)
		{
				case GameStates.States.Starting:
						print("Let the games begin.");
					break;
				
				case GameStates.States.Loading:
						print("Loading Loading Loading");
					break;
				
				case GameStates.States.Playing:
						print("Game running.");
					break;
				
				case GameStates.States.Ending:
					print("You have died.");
					break;
		}
		
	}
}
