using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRInteractorHover : MonoBehaviour
{
    private XRRayInteractor interactor;
    [SerializeField] private Material hoverMaterial;
    [SerializeField] private Material placeHoldMaterial;
    private Material originalMaterial;

    private void Start()
    {
        interactor = GetComponent<XRRayInteractor>();
        interactor.hoverEntered.AddListener(HoverEffect);
        interactor.hoverExited.AddListener(RevertToNormal);
    }

    private void OnDestroy()
    {
        interactor.hoverEntered.RemoveListener(HoverEffect);
        interactor.hoverExited.RemoveListener(RevertToNormal);
    }

    private void HoverEffect(HoverEnterEventArgs args)
    {
       GameObject interactableObject =  args.interactableObject.transform.gameObject;
        originalMaterial = interactableObject.GetComponent<MeshRenderer>().material;
        interactableObject.GetComponent<MeshRenderer>().material = hoverMaterial;   
    }

    private void RevertToNormal(HoverExitEventArgs args)
    {
        GameObject interactableObject = args.interactableObject.transform.gameObject;
        if (originalMaterial == null) { originalMaterial = placeHoldMaterial; }
        interactableObject.GetComponent<MeshRenderer>().material = originalMaterial;
    }
   
}
