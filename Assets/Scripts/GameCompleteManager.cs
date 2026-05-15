using UnityEngine;
public class GameCompleteManager :
    MonoBehaviour
{
    public GameObject gameCompletePanel;
    void Start()
    {
        gameCompletePanel.SetActive(false);
    }
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
        Application.Quit();
    }
}
