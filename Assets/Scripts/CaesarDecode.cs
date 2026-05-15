using UnityEngine;
using UnityEngine.UI;
public class CaesarDecodePuzzle :
    MonoBehaviour,
    IInteractable
{
    [Header("UI")]
    public GameObject puzzlePanel;
    public Text cipherText;
    public InputField answerInput;
    public Text resultText;
    [Header("Puzzle")]
    public string encryptedWord =
        "KHOOR";
    public string correctAnswer =
        "HELLO";
    [Header("Game Complete")]
    public GameCompleteManager
        completeManager;
    bool playerNear = false;
    bool isOpen = false;
    void Start()
    {
        puzzlePanel.SetActive(false);
    }
    public void Interact(RaycastHit hit)
    {
        Debug.Log("call");
        //if (!playerNear || isOpen)
        //    return;
        isOpen = true;
        puzzlePanel.SetActive(true);
        cipherText.text =
            "Decode:\n" + encryptedWord;
        resultText.text = "";
        Cursor.lockState =
            CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
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
            Invoke(nameof(CompleteGame), 1.5f);
        }
        else
        {
            resultText.text =
                "ACCESS DENIED";
        }
    }
    void CompleteGame()
    {
        puzzlePanel.SetActive(false);
        completeManager
            .ShowGameComplete();
    }
    public void ClosePuzzle()
    {
        isOpen = false;
        puzzlePanel.SetActive(false);
        Cursor.lockState =
            CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
    }
    private void OnTriggerEnter(
        Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }
    private void OnTriggerExit(
        Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}