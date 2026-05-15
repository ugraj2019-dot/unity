using UnityEngine;
public class AnalysisBay : MonoBehaviour
{
    public AnalysisDevice targetDevice;
    public void StartAnalysis()
    {
        if (targetDevice == null)
        {
            Debug.Log("No Device Assigned");
            return;
        }
        targetDevice.Analyze();
    }
    public void CompleteAnalysis()
    {
        if (targetDevice.analyzed)
        {
            MissionManager.Instance.CompleteAnalysis();

            UIManager.Instance.ShowAlert(
                "✅ Analysis Completed"
            );
        }
        else
        {
            UIManager.Instance.ShowAlert(
                "Analyze device first!"
            );
        }
    }
}
