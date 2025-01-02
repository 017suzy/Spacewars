using UnityEngine;
using UnityEngine.Events;

public class SignalListener : MonoBehaviour
{
    public Signal signal;
    public UnityEvent signalEvent;
    public void OnSignalRaised(){
        signalEvent.Invoke();
   }
   
   /// This function is called when the object becomes enabled and active.
   /// </summary>
   public void OnEnable()
   {
    signal.RegisterListener(this);       
   }
   /// This function is called when the behaviour becomes disabled or inactive.
   /// </summary>
   public void OnDisable()
   {
       signal.DeRegisterListener(this);
   }
    
}
