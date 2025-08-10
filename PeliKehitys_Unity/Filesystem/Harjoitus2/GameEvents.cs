using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance { get; private set; }

    private void Awake()
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

    public void CollectItem(string itemName)
    {
        LogManager.Instance.LogEvent("Collected item: " + itemName);
    }

    public void OpenDoor(string doorName)
    {
        LogManager.Instance.LogEvent("Opened door: " + doorName);
    }

    public void EnterArea(string areaName)
    {
        LogManager.Instance.LogEvent("Entered area: " + areaName);
    }
}
