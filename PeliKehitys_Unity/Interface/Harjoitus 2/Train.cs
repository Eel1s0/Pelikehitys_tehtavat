using UnityEngine;

public class Train : RailVehicle, IMovable
{
    public void GoForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Reverse()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) GoForward();
        if (Input.GetKey(KeyCode.S)) Reverse();
    }
}
