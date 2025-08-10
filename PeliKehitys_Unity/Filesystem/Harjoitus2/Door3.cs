using UnityEngine;

public class Door3 : MonoBehaviour
{
    public string doorName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameEvents.Instance.OpenDoor(doorName);
        }
    }
}
