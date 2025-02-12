using UnityEngine;

[RequireComponent (typeof(BoxCollider))]

public class PlantPot : MonoBehaviour, Iinteractable
{
    public string GetInteractText()
    {
        return $"Kukkaruukku ker�tty";
    }

    public void Interact()
    {
        print(GetInteractText());
        Destroy(gameObject, 2f);
    }
}
