using UnityEngine;
using UnityEngine.UI;
public class CaesarPuzzle :
    MonoBehaviour,
    IInteractable
{
    public GameObject panel;
    public Text cipherText;
    public InputField answerInput;
    public Text resultText;
    string correctAnswer =
        "HELLO AGENT";
    public void Interact(RaycastHit hit)
    {
        panel.SetActive(true);
        Cursor.lockState =
            CursorLockMode.None;
        Cursor.visible = true;
        cipherText.text =
            "Decrypt:\nKHOOR DJHQW";
        resultText.text = "";
    }
    public void SubmitAnswer()
    {
        string answer =
            answerInput.text.ToUpper();
        if (answer == correctAnswer)
        {
            resultText.text =
                "✅ ACCESS GRANTED";
            Debug.Log("Puzzle Solved");
        }
        else
        {
            resultText.text =
                "❌ WRONG ANSWER";
        }
    }
    public void ClosePuzzle()
    {
        panel.SetActive(false);
        Cursor.lockState =
            CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
