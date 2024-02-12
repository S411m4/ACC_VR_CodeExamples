using UnityEngine;
using UnityEngine.Events;

public class UnityEvents_Example : MonoBehaviour
{
    public UnityEvent hitEvent;


    private void OnTriggerEnter()
    {
        if (hitEvent != null)
        {
            hitEvent.Invoke();            
        }

        //short hand expression for the above null check
        //hitEvent?.Invoke();
    }
}
