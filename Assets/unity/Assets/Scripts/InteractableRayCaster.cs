using UnityEngine;

public class InteractionRaycaster : MonoBehaviour
{
    public float range = 5f;

    public LayerMask interactLayers;

    void Update()
    {
        Ray ray = new Ray(
            transform.position,
            transform.forward);

        if (Physics.Raycast(
            ray,
            out RaycastHit hit,
            range,
            interactLayers))
        {
            Debug.Log(
                "Looking at: " +
                hit.collider.name);

            if (Input.GetKeyDown(KeyCode.E))
            {
                IInteractable interactable =
                    hit.collider
                    .GetComponentInParent<IInteractable>();

                if (interactable != null)
                {
                    interactable.Interact(hit);
                }
            }
        }
    }
}