using UnityEngine;
using UnityEngine.UI;
public class ProjectorInteract : MonoBehaviour
{
    [Header("UI")]
    public GameObject missionPanel;
    public Text missionText;
    [TextArea]
    public string startupMessage =
@"🌐 CYBER DEFENSE HQ

Welcome Agent.

Your mission is to investigate
and secure all compromised systems.

Proceed to the Phishing Room
to begin analysis.";
    bool playerNear = false;
    void Update()
    {
        if (playerNear &&
            Input.GetKeyDown(KeyCode.E))
        {
            ToggleMission();
        }
    }
    void ToggleMission()
    {
        bool active =
            !missionPanel.activeSelf;
        missionPanel.SetActive(active);
        missionText.text = startupMessage;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            UIManager.Instance.ShowAlert(
                "Press E to access projector");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
            missionPanel.SetActive(false);
        }
    }
}
