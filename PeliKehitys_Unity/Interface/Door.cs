using UnityEngine;

public class Door : MonoBehaviour, Iinteractable
{

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public string GetInteractText()
    {
        return "Avaa ovi";
    }

    public void Interact()
    {
        print(GetInteractText());
        anim.SetTrigger("OpenDoor");
    }
}
