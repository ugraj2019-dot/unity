using UnityEngine;
public class ServerRoom : MonoBehaviour
{
    public bool serverSecured = false;
    public void SecureServer()
    {
        serverSecured = true;
        UIManager.Instance.ShowAlert(
            "🖥️ Server Secured"
        );
    }
    public void CompleteRoom()
    {
        if (serverSecured)
        {
            MissionManager.Instance.CompleteServer();
            UIManager.Instance.ShowAlert(
                "✅ Server Room Completed"
            );
        }
        else
        {
            UIManager.Instance.ShowAlert(
                "Secure the server first!"
            );
        }
    }
}
