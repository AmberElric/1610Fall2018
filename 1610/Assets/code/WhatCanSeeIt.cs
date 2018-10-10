using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatCanSeeIt  : ScriptableObject
{

    private float health;
    protected float Powerlevel;
    public float EvergyLevel;

    private void AddHealth()
    {
       health += 100 
    }

    protected void AddPower()
    {
        AddHealth();
    }

    public void AddEnergy()
    {
        
    }
}

public class ICanSeeIt : MonoBehaviour
{
    private WhatCanSeeIt newObject;


    private void Start()
    {
        newObject.EvergyLevel = 100;
        newObject.AddEnergy();
    }
}

public class Child : WhatCanSeeIt
{
    void callThings()
    {
        Powerlevel = 200;
        EvergyLevel = 300;
        AddPower();
        AddEnergy();
    }
}