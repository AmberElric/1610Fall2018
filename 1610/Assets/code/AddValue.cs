
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]
public class AddValue : ScriptableObject
{
    public FloatData ValueObject;
    public UnityEvent EventMin;
    public UnityEvent EventMax;
    public FloatData MaxValue;
    public FloatData MinValue;
    public void AddValueToObject(FloatData data)
    {
        ValueObject.Value += data.Value;

        if (ValueObject.Value >= MaxValue.Value)
        {
            EventMax.Invoke();
            
        }
        
        if (ValueObject.Value <= MinValue.Value)
        {
            EventMin.Invoke();
            
        }
        
    }
    
}
