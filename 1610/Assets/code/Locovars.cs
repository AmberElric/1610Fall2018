﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locovars : MonoBehaviour
{

	public string Name;

	public void Call()
	{
		Name = "Bobbie";
		print(Name);
	}

	public void Call(string newName)
	{
		print(newName);
		print(Name);
	}

}
