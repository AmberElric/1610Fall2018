using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
	public int A, B, C;
	public string Password;
	public bool LightOn;
	public NameID Lock, Key;
	public FloatData WizardPower, PawnPower;
	// Update is called once per frame
	void Update () {
		if (Lock == Key)
		{
			print("open door");
		}
		
		
		
		
		if (LightOn)
		{
			print("Lights on but no body is home.");
		}
		else
		{
			print("Oh no it's dark");
		}

		if (Password == "ou812")
		{
			print("what.");
		}

		if (C == A + B)
		{
			print(C);
		}
		else
		{
			print("incorrect");
		}
//checks to see if it is false
		if (Password != "ou812")
		{
			print("password correct");
		}

		if (WizardPower.Value > PawnPower.Value)
		{
			print("Wizard wins.");
		}
		else
		{
			print("Pawn wins");
		}
	}
	
	
}
