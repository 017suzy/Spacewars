using UnityEngine;
using UnityEngine.Events;

public class SignalListener1 : MonoBehaviour
{
    public Signal1 signal1;
    public UnityEvent signalEvent1;
    public void OnSignalRaised(){
        signalEvent1.Invoke();
   }
   
   /// This function is called when the object becomes enabled and active.
   /// </summary>
   public void OnEnable()
   {
    signal1.RegisterListener(this);       
   }
   /// This function is called when the behaviour becomes disabled or inactive.
   /// </summary>
   public void OnDisable()
   {
       signal1.DeRegisterListener(this);
   }
    
}
