using UnityEngine;
using System;
public class MissionManager : MonoBehaviour
{
    public static MissionManager Instance;
    public enum MissionState
    {
        Start,
        PhishingDone,
        AnalysisDone,
        MalwareContained,
        ServerSecured,
        Completed
    }
    public MissionState currentMission = MissionState.Start;
    public event Action<MissionState> OnMissionChanged;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void CompletePhishing()
    {
        SetMission(MissionState.PhishingDone);
    }
    public void CompleteAnalysis()
    {
        SetMission(MissionState.AnalysisDone);
    }
    public void CompleteMalware()
    {
        SetMission(MissionState.MalwareContained);
    }
    public void CompleteServer()
    {
        SetMission(MissionState.ServerSecured);
    }
    public void CompleteGame()
    {
        SetMission(MissionState.Completed);
    }
    void SetMission(MissionState newState)
    {
        if (newState <= currentMission) return;
        currentMission = newState;
        Debug.Log("Mission Updated: " + currentMission);
        OnMissionChanged?.Invoke(currentMission);
    }
    public bool CanAccess(MissionState requiredState)
    {
        return currentMission >= requiredState;
    }
}
