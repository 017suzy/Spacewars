using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Signal1", menuName = "Scriptable Objects/Signal1")]
public class Signal1 : ScriptableObject
{
    public List<SignalListener1> listeners1 = new List<SignalListener1>();
    public void Raise(){
        for(int i = listeners1.Count - 1;    i >= 0; i--){
            listeners1[i].OnSignalRaised();
        }
        
    }

    public void RegisterListener(SignalListener1 listener1){
        listeners1.Add(listener1);
    }
    public void DeRegisterListener(SignalListener1 listener1){
        listeners1.Remove(listener1);
    }

   
    
}
