using UnityEngine;

public class Item4 : MonoBehaviour
{
    public string itemName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameEvents.Instance.CollectItem(itemName);
            Destroy(gameObject);
        }
    }
}
