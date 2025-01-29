using UnityEngine;
using UnityEngine.InputSystem;

public class SettingsTesti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.digit1Key.wasPressedThisFrame) 
        {
            SettingsManager.Instance.Brightness = 4.2f;
        }

        if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            SettingsManager.Instance.Volume = 5.0f;
        }
    }
}
