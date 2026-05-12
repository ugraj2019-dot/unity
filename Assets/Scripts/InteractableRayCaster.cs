using UnityEngine;
public class InteractionRaycaster : MonoBehaviour
{
    [Header("Interaction Settings")]
    [SerializeField] private float range = 3f;
    [SerializeField]
    private KeyCode interactKey =
        KeyCode.E;
    [SerializeField] private LayerMask layerMask = ~0;
    private void Update()
    {
        Ray ray = new Ray(
            transform.position,
            transform.forward);
        if (Physics.Raycast(
            ray,
            out RaycastHit hit,
            range,
            layerMask))
        {
         //   Debug.DrawRay(
           //     ray.origin,
             //   ray.direction * range,
               // Color.green);
            IInteractable interactable =
                hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                Debug.Log(
                    "Looking at: " +
                    hit.collider.name);
                if (Input.GetKeyDown(interactKey))
                {
                    interactable.Interact(hit);
                }
            }
        }
        else
        {
           // Debug.DrawRay(
             //   ray.origin,
               // ray.direction * range,
                //Color.red);
        }
    }
}
