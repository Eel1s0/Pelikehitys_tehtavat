using UnityEngine;

public class PlayerController5 : MonoBehaviour
{
    public float speed = 5f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        rb.linearVelocity = movement * speed;
    }
}
