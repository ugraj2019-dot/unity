using UnityEngine;
using UnityEngine.UI;
public class CaesarPuzzle :
    MonoBehaviour,
    IInteractable
{
    public GameObject puzzlePanel;
    public Text cipherText;
    public InputField answerInput;
    public Text resultText;
    string correctAnswer =
        "HELLO";
    void Start()
    {
        puzzlePanel.SetActive(false);
    }
    public void Interact(RaycastHit hit)
    {
        Debug.Log("Puzzle Opened");
        puzzlePanel.SetActive(true);
        cipherText.text =
            "Decrypt: KHOOR";
        resultText.text = "";
        Cursor.lockState =
            CursorLockMode.None;
        Cursor.visible = true;
    }
    public void SubmitAnswer()
    {
        Debug.Log("Submit Pressed");
        string answer =
            answerInput.text
            .ToUpper()
            .Trim();
        Debug.Log(answer);
        if (answer == correctAnswer)
        {
            resultText.text =
                "CORRECT";
        }
        else
        {
            resultText.text =
                "WRONG";
        }
    }
}