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
            Cursor.lockState =
                CursorLockMode.None;
            Cursor.visible = true;
        }
        if (popupPanel.activeSelf &&
            Input.GetKeyDown(KeyCode.Escape))
        {
            ClosePopup();
        }
    }
    public void ClosePopup()
    {
        popupPanel.SetActive(false);
        Cursor.lockState =
            CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            //UIManager.Instance.ShowAlert(
              //  "Press E to access projector");
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