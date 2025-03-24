using UnityEngine;

public class Truck : MonoBehaviour
{
    private TruckAudio truckAudio;
    private TruckInput truckInput;
    private TruckMovement truckMovement;

    private void Awake()
    {
        truckAudio = GetComponent<TruckAudio>();
        truckInput = GetComponent<TruckInput>();
        truckMovement = GetComponent<TruckMovement>();
    }

    private void Update()
    {
        truckMovement.MoveDumpTruck(truckInput.VerticalInput, truckInput.HorizontalInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        truckAudio.HandleAudio();
        Destroy(other.gameObject);
    }
}
