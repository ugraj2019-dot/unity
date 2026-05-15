using UnityEngine;
public class GameCompleteManager :
    MonoBehaviour
{
    public GameObject
        gameCompletePanel;
    public void ShowGameComplete()
    {
        gameCompletePanel.SetActive(true);
        Cursor.lockState =
            CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }
    public void ExitGame()
    {
        Debug.Log("EXIT WORKING");
        gameCompletePanel.SetActive(false);
        Cursor.lockState =
            CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
    }
}