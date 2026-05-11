using UnityEngine;
public class ExitRoom : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (MissionManager.Instance.currentMission ==
            MissionManager.MissionState.ServerSecured)
        {
            UIManager.Instance.ShowAlert(
                "🏆 SYSTEM SECURED - YOU WIN!"
            );
            Debug.Log("GAME COMPLETED");
        }
        else
        {
            UIManager.Instance.ShowAlert(
                "Complete all rooms first!"
            );
        }
    }
}
