using UnityEngine;

public class TruckMovement : MonoBehaviour
{

    private float speed = 3.0f;
    private float turnSpeed = 45.0f;

    public void MoveDumpTruck(float forwardInput, float horizontalInput)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
