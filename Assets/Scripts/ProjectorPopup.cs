using UnityEngine;
public class ProjectorPopup : MonoBehaviour
{
    public GameObject popupPanel;
    bool playerNear = false;
    void Start()
    {
        popupPanel.SetActive(false);
    }
    void Update()
    {
        if (playerNear &&
            Input.GetKeyDown(KeyCode.E))
        {
            popupPanel.SetActive(true);
        }
    }
    public void ClosePopup()
    {
        popupPanel.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            UIManager.Instance.ShowAlert(
                "Press E to access projector");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}
