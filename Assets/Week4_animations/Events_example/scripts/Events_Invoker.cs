using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
using UnityEngine.Events; 

/// <summary>
/// types of built-in delegates, and creating custom delegate
/// </summary>
public class Events_Invoker : MonoBehaviour
{

    public static Events_Invoker instance; 
    //singletone pattern
    //used if will be only one instance of this class in the whole game

    private void Awake()
    {
        instance = this;
    }

    public event EventHandler eventHandlerEvent;
    //EventHandler
    //can be incoked with no parameters
    //can take custom input, define by EventArgs class

    public event EventHandler<MyParameters> eventHandlerEventWithParameters;
    public class MyParameters : EventArgs
    {
        public bool testBool;
        public float testFloat;

    }

    public Action actionEvent;
    public Action<bool> actionEventWithParameters; 
    //Action<>
    //can be invoked with no parameters
    //and can take generic parameters, don't return anything

    public event Func<bool> funcEvent; 
    public event Func<float, bool, bool> funcEventWithParameters;
    //Func<>
    //requires at least one argument
    //takes as many arguments as you want, and the last parameter is always the return type


    [SerializeField] UnityEvent myUnityEvent;

    



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            eventHandlerEvent?.Invoke(this, EventArgs.Empty);
            eventHandlerEventWithParameters?.Invoke(this, new MyParameters{testBool = false, testFloat = 5});

            actionEvent();
            actionEventWithParameters(true);

            funcEvent();

            myUnityEvent?.Invoke();
        }
    }
}
