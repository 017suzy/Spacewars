using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Signal", menuName = "Scriptable Objects/Signal")]
public class Signal : ScriptableObject
{
    public List<SignalListener> listeners = new List<SignalListener>();
    public void Raise(){
        for(int i = listeners.Count - 1;    i >= 0; i--){
            listeners[i].OnSignalRaised();
        }
        
    }

    public void RegisterListener(SignalListener listener){
        listeners.Add(listener);
    }
    public void DeRegisterListener(SignalListener listener){
        listeners.Remove(listener);
    }

   
    
}
