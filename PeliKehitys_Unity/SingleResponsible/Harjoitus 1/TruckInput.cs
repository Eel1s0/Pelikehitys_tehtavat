using UnityEngine;

public class TruckInput : MonoBehaviour
{
    public float HorizontalInput
    {
        get
        {
            return Input.GetAxis("Horizontal");
        }
    }
    public float VerticalInput => Input.GetAxis("Vertical");
}
