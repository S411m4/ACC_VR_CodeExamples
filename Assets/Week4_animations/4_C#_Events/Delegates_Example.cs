using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//delegates are variables that store functions
public class Delegates_Example : MonoBehaviour
{

    private delegate void VoidDeglate();   //declare type
    private delegate void IntDelegate(int no);   //declare type
    private delegate float ReturnDelegate();   //declare type

    VoidDeglate myFunc;
    IntDelegate intFunc;
    ReturnDelegate returnFunc;

    private void Start()
    {
        myFunc += PrintHello;
        myFunc += PrintHi;
        //intFunc += PrintNo;
        //returnFunc += Return6;
    }

    private void OnDestroy()
    {
        myFunc -= PrintHello;
        myFunc -= PrintHi;
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (myFunc != null) myFunc.Invoke();

        //intFunc?.Invoke(5);

        //if(returnFunc != null)
        //{
        //    float result = returnFunc.Invoke();
        //    Debug.Log("result: " + result);
        //}

    }

    private float Return6()
    {
        return 6f;
    }
    private void PrintNo(int no)
    {
        Debug.Log(no);
    }

    private void PrintHello()
    { Debug.Log("Hello"); }

    private void PrintHi()
    { Debug.Log("Hi"); }



    ////declaring delegate type 
    //private delegate void NoReturnNoParamDelegate();
    //private delegate int intReturnDelegate();
    //private delegate void intParamDelegate(int x);

    ////defining variable of delegate type (space in memory to store a function with certain signature)
    //private NoReturnNoParamDelegate greetingDelegate;
    //private intParamDelegate printNoDelegate;


    //private void Start()
    //{
    //    //greetingDelegate += PrintHello;
    //    //greetingDelegate += PrintHi;

    //    printNoDelegate += PrintNo;
    //    printNoDelegate += PrintAnotherNo;
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    greetingDelegate?.Invoke();
    //    printNoDelegate?.Invoke(5);
    //}


    //private void PrintHello() { Debug.Log("Hello"); }
    //private void PrintHi() { Debug.Log("Hi"); }

    //private void PrintNo(int no) { Debug.Log(no); }
    //private void PrintAnotherNo(int no) { Debug.Log("another No: " + no); }
}
