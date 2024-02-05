using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//delegates are variables that store functions
public class Delegates_Example : MonoBehaviour
{
    //declaring delegate type 
    private delegate void NoReturnNoParamDelegate();
    private delegate int intReturnDelegate();
    private delegate void intParamDelegate(int x);

    //defining variable of delegate type (space in memory to store a function with certain signature)
    private NoReturnNoParamDelegate greetingDelegate;
    private intParamDelegate printNoDelegate;


    private void Start()
    {
        //greetingDelegate += PrintHello;
        //greetingDelegate += PrintHi;

        printNoDelegate += PrintNo;
        printNoDelegate += PrintAnotherNo;
    }

    private void OnTriggerEnter(Collider other)
    {
        greetingDelegate?.Invoke();
        printNoDelegate?.Invoke(5);
    }


    private void PrintHello() { Debug.Log("Hello"); }
    private void PrintHi() { Debug.Log("Hi"); }

    private void PrintNo(int no) { Debug.Log(no); }
    private void PrintAnotherNo(int no) { Debug.Log("another No: " + no); }
}
