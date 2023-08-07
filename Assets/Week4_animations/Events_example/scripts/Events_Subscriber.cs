using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events_Subscriber : MonoBehaviour
{
    
    private void Start()
    {
        Events_Invoker.instance.eventHandlerEvent += Invoker_eventHandlerEvent;
        Events_Invoker.instance.eventHandlerEventWithParameters += Invoker_eventHandlerEventWithParameters;
        Events_Invoker.instance.actionEvent += Invoker_actionEvent;
        Events_Invoker.instance.actionEventWithParameters += Invoker_actionEventWithParameters;
        Events_Invoker.instance.funcEvent += Invoker_funcEvent;




    }


    private void Invoker_eventHandlerEvent(object sender, System.EventArgs e)
    {
        Debug.Log("eventHandler");
    }

    private void Invoker_eventHandlerEventWithParameters(object sender, Events_Invoker.MyParameters myParameters)
    {
        Debug.Log("eventHandler with parameters:  " + myParameters.testFloat + "," + myParameters.testBool);
    }

    private void Invoker_actionEvent()
    {
        Debug.Log("action");
    }

    private void Invoker_actionEventWithParameters(bool b)
    {
        Debug.Log("action with parameters, " + b);
    }

    private bool Invoker_funcEvent()
    {
        Debug.Log("Func");
        return false;
    }


    public void PrintUntiyEvent()
    {
        Debug.Log("unityEvent");
    }

 
}
