using UnityEngine;
public class PlayerInteract : MonoBehaviour
{
    public float range = 3f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray =
                Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, range))
            {
                AnalysisDevice device =
                    hit.collider.GetComponent<AnalysisDevice>();
                if (device != null)
                {
                    device.Analyze();
                }
            }
        }
    }
}
