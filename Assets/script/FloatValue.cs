using UnityEngine;

[CreateAssetMenu(fileName = "FloatValue", menuName = "Scriptable Objects/FloatValue")]
public class FloatValue : ScriptableObject, ISerializationCallbackReceiver
{
    public float initialValue;
    [HideInInspector]
    public float RuntimeValue;

    public void OnAfterDeserialize(){
        RuntimeValue = initialValue;
    }
    public void OnBeforeSerialize(){

    }
}
