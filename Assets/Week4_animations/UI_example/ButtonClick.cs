using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private Button button;

  private void Start()
  {
    button.onClick.AddListener(Print); 

    button.onClick.AddListener(() => Debug.Log("Lambda function"));
  }

  public void Print()
  {
    Debug.Log("button __");
  }
}
