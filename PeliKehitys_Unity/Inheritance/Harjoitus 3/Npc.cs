using UnityEngine;

public class Npc : Interactable
{
    [SerializeField] protected string npcName; // Changed to protected
    [SerializeField] protected string[] dialogue; // Changed to protected

    public override void Interact()
    {
        DialogueSystem.Instance.AddNewDialogue(dialogue, npcName);
    }
}
