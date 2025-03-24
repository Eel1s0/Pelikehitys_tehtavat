using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void MovePlayer(float horizontalInput, float verticalInput)
    {
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        rb.linearVelocity = movement * speed;
    }
}
