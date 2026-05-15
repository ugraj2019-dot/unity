using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [Header("UI Elements")]
    public GameObject alertPanel;
    public Text alertText;
    [Header("Settings")]
    public float displayTime = 2f;
    void Awake()
    {
        Instance = this;
        alertPanel.SetActive(false);
    }
    public void ShowAlert(string message)
    {
        StopAllCoroutines();
        StartCoroutine(AlertRoutine(message));
    }
    IEnumerator AlertRoutine(string message)
    {
        alertPanel.SetActive(true);
        alertText.text = message;
        yield return new WaitForSeconds(displayTime);
        alertPanel.SetActive(false);
    }
}
