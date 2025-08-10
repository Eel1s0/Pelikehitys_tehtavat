using UnityEngine;

public class AreaTrigger : MonoBehaviour
{
    public string areaName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameEvents.Instance.EnterArea(areaName);
        }
    }
}
