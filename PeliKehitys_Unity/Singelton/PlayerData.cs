using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance { get; set; }

    private string name;
    private int level;
    private int health;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            //return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
    }


    public void SaveData(string _name, int _level, int _health)
    {
        name = _name;
        level = _level;
        health = _health;

        print($"Tallennettavat tiedot: nimi: {_name}, taso: {_level}, terveys: {_health}");
    }

    public void LoadData()
    {
        print($"Ladattavat tiedot nimi: {name}, taso: {level}, terveys: {health}");
    }
}
