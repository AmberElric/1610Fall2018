using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]
public class MuiltValue : ScriptableObject
{

    public FloatData Multi;

    public void OnMulitValue(FloatData outsideData)
    {
        outsideData.Value *= Multi.Value;
    }
}
