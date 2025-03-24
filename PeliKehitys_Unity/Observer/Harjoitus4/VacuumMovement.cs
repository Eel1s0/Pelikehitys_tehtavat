using UnityEngine;
public class VacuumMovement : MonoBehaviour
{
    // Set player's movement speed.
    public float speed = 5.0f;
    // Set player's rotation speed.
    public float rotationSpeed = 120.0f;
    public void MoveVacuum(Rigidbody rb, Vector2 movement)
    {
        // Move player based on vertical input.
        Vector3 forward = transform.forward * movement.x * speed *
        Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forward);
        // Rotate player based on horizontal input.
        float turn = movement.y * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}