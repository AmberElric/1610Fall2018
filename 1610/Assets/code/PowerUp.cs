using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]
public class PowerUp : ScriptableObject
{
   
    public FloatData Data;
    
    public void OnPowerUp(FloatData outsideData)
    {
        outsideData.Value -= Data.Value;
    }
}
//have a flaot data write another script call value change, add value, mulitply value, divide value, subtract data