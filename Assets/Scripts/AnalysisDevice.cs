using UnityEngine;
public class AnalysisDevice : MonoBehaviour
{
    public bool isInfected = true;
    public bool analyzed = false;
    public void Analyze()
    {
        if (analyzed) return;
        analyzed = true;
        if (isInfected)
        {
            Debug.Log("⚠️ Threat Found");
            UIManager.Instance.ShowAlert("⚠️ Threat Detected!");
        }
        else
        {
            Debug.Log("✅ Device Safe");
            UIManager.Instance.ShowAlert("✅ Device Safe");
        }
    }
}