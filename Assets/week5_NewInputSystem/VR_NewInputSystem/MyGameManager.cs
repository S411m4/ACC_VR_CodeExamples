using UnityEngine;
using UnityEngine.InputSystem;
public class MyGameManager : MonoBehaviour
{
    [SerializeField] InputActionReference switchControllersAction;
    [SerializeField] InputActionReference testDebugAction;

    bool rayActive = true;
    [SerializeField] private GameObject directLeft;
    [SerializeField] private GameObject directRight;
    [SerializeField] private GameObject rayLeft;
    [SerializeField] private GameObject rayRight;

    private void OnEnable()
    {
        switchControllersAction.action.Enable();
        testDebugAction.action.Enable();
        switchControllersAction.action.performed += ToggleControllers;
        testDebugAction.action.performed += DebugTest;
    }

    private void DebugTest(InputAction.CallbackContext obj)
    {
        Debug.Log("OKKKKK");  
    }

    private void OnDisable()
    {
        switchControllersAction.action.performed -= ToggleControllers;
        testDebugAction.action.performed -= DebugTest;
    }

    private void ToggleControllers(InputAction.CallbackContext obj)
    {
        //Debug.Log("switching");
        rayActive = !rayActive;

        if (rayActive)
        {
            directLeft.SetActive(false);
            directRight.SetActive(false);
            rayLeft.SetActive(true);
            rayRight.SetActive(true);
        }
        else
        {
            directLeft.SetActive(true);
            directRight.SetActive(true);
            rayLeft.SetActive(false);
            rayRight.SetActive(false);
        }
    }

}
