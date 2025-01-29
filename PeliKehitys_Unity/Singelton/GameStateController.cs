using UnityEngine;
using UnityEngine.InputSystem;

public class GameStateController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.jKey.wasPressedThisFrame)
        {
            GameStateManager.Instance.ChangeState(GameStateManager.GameState.MainMenu);
        }

        if (Keyboard.current.kKey.wasPressedThisFrame)
        {
            GameStateManager.Instance.ChangeState(GameStateManager.GameState.Playing);

        }

        if (Keyboard.current.lKey.wasPressedThisFrame)
        {
            GameStateManager.Instance.ChangeState(GameStateManager.GameState.Pause);

        }


    }
}
