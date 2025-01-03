using UnityEngine;

[CreateAssetMenu]
public class FloatSO : ScriptableObject
{
    [SerializeField] private float valuescore; 

    public float Value
    {
        get { return valuescore; }
        set { valuescore = value; }
    }
}
