using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Koordinaattori, joka vain v‰litt‰‰ teht‰vi‰ komponteille
/// </summary>
[RequireComponent(typeof(PlayerInput), typeof(NewPlayerInput), typeof
(VacuumMovement))]
public class VacuumController : MonoBehaviour
{
    // Reference to player's Rigidbody.
    private Rigidbody rb;
    // Reference to player's Movement.
    private VacuumMovement movement;
    // Reference to player's Inputs.
    private NewPlayerInput playerInput;
    // Start is called before the first frame update
    private void Awake()
    {
        // Access player's Rigidbody.
        rb = GetComponent<Rigidbody>();
        // Access player's Movement.
        movement = GetComponent<VacuumMovement>();
        // Access player's Inputs.
        playerInput = GetComponent<NewPlayerInput>();
    }
    //
    private void FixedUpdate()
    {
        movement.MoveVacuum(rb, playerInput.Movement);
    }
}