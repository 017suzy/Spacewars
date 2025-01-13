using UnityEngine;

[CreateAssetMenu(fileName = "FloatValue1", menuName = "Scriptable Objects/FloatValue1")]
public class FloatValue1 : ScriptableObject, ISerializationCallbackReceiver
{
    public float initialValue1;
    [HideInInspector]
    public float RuntimeValue1;

    public void OnAfterDeserialize(){
        RuntimeValue1 = initialValue1;
    }
    public void OnBeforeSerialize(){

    }
}
