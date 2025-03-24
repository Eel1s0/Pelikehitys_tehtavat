using UnityEngine;
using UnityEngine.InputSystem;
public class NewPlayerInput : MonoBehaviour
{
    public Vector2 Movement { get; set; }
    public void OnMove(InputValue inputValue)
    {
        Movement = inputValue.Get<Vector2>();
    }
}