using UnityEngine;
using System.IO;
using TMPro;

public class LogManager : MonoBehaviour
{
    public static LogManager Instance { get; private set; }
    private string logFilePath;
    [SerializeField] private TMP_Text logText;

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

        string folderPath = Path.Combine(Application.persistentDataPath, "game_data");
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        logFilePath = Path.Combine(folderPath, "game_log.txt");
        LogEvent("Game Started: " + System.DateTime.Now);
    }

    public void LogEvent(string text)
    {
        File.AppendAllText(logFilePath, text + "\n");
        UpdateLogUI();
    }

    private void UpdateLogUI()
    {
        if (logText != null)
        {
            logText.text = File.ReadAllText(logFilePath);
        }
    }

    public void DeleteLogFiles()
    {
        string folderPath = Path.Combine(Application.persistentDataPath, "game_data");
        if (Directory.Exists(folderPath))
        {
            Directory.Delete(folderPath, true);
            logText.text = "Log cleared.";
        }
    }

    private void OnApplicationQuit()
    {
        LogEvent("Game Ended: " + System.DateTime.Now);
    }
}
