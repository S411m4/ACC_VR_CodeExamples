using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] private GameObject canva1;
    [SerializeField] private GameObject canva2;

    [SerializeField] private Button btn1;
    [SerializeField] private Button btn2;

    private void Start()
    {
        HideAll();
        btn1.onClick.AddListener(() => { HideAll(); canva1.SetActive(true); });
        btn2.onClick.AddListener(() => { HideAll(); canva2.SetActive(true); });
    }


    private void HideAll()
    {
        canva1.SetActive(false);
        canva2.SetActive(false);
    }



    
}
