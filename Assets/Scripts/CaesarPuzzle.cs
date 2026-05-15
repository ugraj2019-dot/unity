using UnityEngine;
using UnityEngine.UI;

public class CaesarPuzzle :
    MonoBehaviour,
    IInteractable
{
    public GameObject puzzlePanel;

    public InputField answerInput;

    public Text resultText;

    string correctAnswer =
        "HELLO";

    bool isOpen = false;

    public void Interact(RaycastHit hit)
    {
        if (isOpen) return;

        isOpen = true;

        puzzlePanel.SetActive(true);

        Time.timeScale = 0f;

        Cursor.lockState =
            CursorLockMode.None;

        Cursor.visible = true;

        resultText.text = "";
    }

    public void SubmitAnswer()
    {
        string answer =
            answerInput.text
            .ToUpper()
            .Trim();

        if (answer == correctAnswer)
        {
            resultText.text =
                "ACCESS GRANTED";
        }
        else
        {
            resultText.text =
                "ACCESS DENIED";
        }
    }

    public void ClosePuzzle()
    {
        isOpen = false;

        puzzlePanel.SetActive(false);

        Time.timeScale = 1f;

        Cursor.lockState =
            CursorLockMode.Locked;

        Cursor.visible = false;
    }
}