using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;
using System;

public class RebindKeysCanvaManager : MonoBehaviour
{
    [SerializeField] private Button moveUpBtn;
    [SerializeField] private Button moveDownBtn;
    [SerializeField] private Button moveLeftBtn;
    [SerializeField] private Button moveRightBtn;
    [SerializeField] private Button jumpBtn;

    [SerializeField] private TextMeshProUGUI upText;
    [SerializeField] private TextMeshProUGUI downText;
    [SerializeField] private TextMeshProUGUI leftText;
    [SerializeField] private TextMeshProUGUI rightText;
    [SerializeField] private TextMeshProUGUI jumpText;

    [SerializeField] private GameObject readyToBindCanva;

    [SerializeField] private Button rebindKeysBtn;
    [SerializeField] private GameObject bindingCanva;



    private MyActionsRebind myActionsRebind;
    private bool showBindingCanva = false;


    public enum Binding
    {
        Up, Down, Left, Right, Jump
    }


    private void Start()
    {
        myActionsRebind = Player_.instance.GetPlayerActions();

        HideReadyToBindCanva();
        ShowHideBindingCanva();

        moveUpBtn.onClick.AddListener(() => { ShowReadyToBindCanva(); Rebind(Binding.Up); });
        moveDownBtn.onClick.AddListener(() => { ShowReadyToBindCanva(); Rebind(Binding.Down); });
        moveLeftBtn.onClick.AddListener(() => { ShowReadyToBindCanva(); Rebind(Binding.Left); });
        moveRightBtn.onClick.AddListener(() => { ShowReadyToBindCanva(); Rebind(Binding.Right); });
        jumpBtn.onClick.AddListener(() => { ShowReadyToBindCanva(); Rebind(Binding.Jump); });

        rebindKeysBtn.onClick.AddListener(ShowHideBindingCanva);
    }

    private void SetBindingText(Binding binding)
    {
        //make sure to get the index form the order of bindings in your input action
        //order: up, left, down, right
        switch(binding)
        {
            case Binding.Up:
                upText.text = myActionsRebind.Player.move.bindings[1].ToDisplayString();
                //we started from index 1 because index 0 if the composite parent holding the four bindings of movement
                break;

            case Binding.Left:
                leftText.text = myActionsRebind.Player.move.bindings[2].ToDisplayString();
                break;


            case Binding.Down:
                downText.text = myActionsRebind.Player.move.bindings[3].ToDisplayString();
                break;


            case Binding.Right:
                rightText.text = myActionsRebind.Player.move.bindings[4].ToDisplayString();
                break;


            case Binding.Jump:
                jumpText.text = myActionsRebind.Player.jump.bindings[0].ToDisplayString();
                break;
        }
    }

    private void Rebind(Binding binding)
    {
        myActionsRebind.Player.Disable(); //to avoid any errors or unexpected behaviours


        InputAction inputAction;
        int bindingIndex;

        //assign the binding index and binding action
        switch(binding)
        {
            default:
            case Binding.Up:
                inputAction = myActionsRebind.Player.move;
                bindingIndex = 1;
                break;

            case Binding.Left:
                inputAction = myActionsRebind.Player.move;
                bindingIndex = 2;
                break;

            case Binding.Down:
                inputAction = myActionsRebind.Player.move;
                bindingIndex = 3;
                break;

            case Binding.Right:
                inputAction = myActionsRebind.Player.move;
                bindingIndex = 4;
                break;

            case Binding.Jump:
                inputAction = myActionsRebind.Player.jump;
                bindingIndex = 0;
                break;
        }

        //use rebind function in the new input system
        inputAction.PerformInteractiveRebinding(bindingIndex).OnComplete(callback =>
            {
                callback.Dispose();
                myActionsRebind.Enable();
                SetBindingText(binding);
                HideReadyToBindCanva();

            }

        ).Start();
    }

    private void HideReadyToBindCanva()
    {
        readyToBindCanva.SetActive(false);
    }

    private void ShowReadyToBindCanva()
    {
        readyToBindCanva.SetActive(true);

    }

    private void ShowHideBindingCanva()
    {
        bindingCanva.SetActive(showBindingCanva);
        showBindingCanva = !showBindingCanva;

    }







}
