using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.nKey.wasPressedThisFrame) {PlayerData.Instance.SaveData("Tero", 15, 95);}
        if (Keyboard.current.lKey.wasPressedThisFrame) {PlayerData.Instance.LoadData();}
    }
}
