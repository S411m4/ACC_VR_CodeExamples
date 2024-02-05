using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

//adding listeners to buttons by script
//you can add multiple listeners to same UI element
//all listeners will be executed when event is triggered from UI element
public class ButtonClick : MonoBehaviour
{
    [SerializeField] private Button button;

  private void Start()
  {
    button.onClick.AddListener(PrintFromScript); 

    button.onClick.AddListener(() => Debug.Log("Lambda function"));
    button.onClick.AddListener(() => PrintWithParameters("Salma"));
  }

  public void PrintFromInspector()
  {
    Debug.Log("print from inspector");
  }

public void PrintFromScript()
{
    Debug.Log("SCRIPT");
}

    private void OnDestroy()
    {
        button.onClick.RemoveAllListeners();
    }

    public void PrintWithParameters(string name)
    {
        Debug.Log("Hello " + name);
    }
}


