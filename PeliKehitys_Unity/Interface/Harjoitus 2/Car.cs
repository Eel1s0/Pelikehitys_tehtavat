using UnityEngine;

public class Car : RoadVehicle, IMovable, ITurnable
{
    public void GoForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Reverse()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    public void TurnLeft()
    {
        transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    }

    public void TurnRight()
    {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) GoForward();
        if (Input.GetKey(KeyCode.S)) Reverse();
        if (Input.GetKey(KeyCode.A)) TurnLeft();
        if (Input.GetKey(KeyCode.D)) TurnRight();
    }
}
