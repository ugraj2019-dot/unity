using UnityEngine;
using UnityEngine.UI;
public class CaesarEncodePuzzle :
    MonoBehaviour,
    IInteractable
{
    [Header("UI")]
    public GameObject puzzlePanel;
    public Text taskText;
    public InputField answerInput;
    public Text resultText;
    [Header("Puzzle")]
    public string normalWord =
        "AGENT";
    public string encodedAnswer =
        "DJHQW";
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
        //if (!playerNear || isOpen)
        //    return;
        isOpen = true;
        puzzlePanel.SetActive(true);
        taskText.text =
            "Encode:\n" + normalWord;
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
        if (answer == encodedAnswer)
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
        if (completeManager != null)
        {
            completeManager
                .ShowGameComplete();
        }
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