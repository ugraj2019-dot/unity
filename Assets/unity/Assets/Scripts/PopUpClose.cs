using UnityEngine;
public class PopupClose : MonoBehaviour
{
    public GameObject popupPanel;
    public void ClosePopup()
    {
        popupPanel.SetActive(false);
        Cursor.lockState =
            CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
