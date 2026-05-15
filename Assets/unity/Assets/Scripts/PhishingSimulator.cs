using UnityEngine;
public class PhishingRoom : MonoBehaviour
{
    public bool phishingSolved = false;
    public void DetectPhishing()
    {
        phishingSolved = true;
        UIManager.Instance.ShowAlert(
            "🎣 Phishing Attempt Detected!"
        );
    }
    public void CompleteRoom()
    {
        if (phishingSolved)
        {
            MissionManager.Instance.CompletePhishing();
            UIManager.Instance.ShowAlert(
                "✅ Phishing Room Completed"
            );
        }
        else
        {
            UIManager.Instance.ShowAlert(
                "Find the phishing email first!"
            );
        }
    }
}