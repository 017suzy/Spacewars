using UnityEngine;

public class Enemy : MonoBehaviour
{
    public event System.Action OnDestroyed;

    private void OnDestroy()
    {
        OnDestroyed?.Invoke();
    }
}