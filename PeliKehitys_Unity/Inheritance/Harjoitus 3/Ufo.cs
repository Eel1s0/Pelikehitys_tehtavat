using UnityEngine;

public class Ufo : ActionItem
{
    [SerializeField] private string ufoName = "Unski";
    [SerializeField]
    private string[] dialogue =
    {
        "Hei maan asukas!",
        "Tulen ulkoavaruudesta.",
        "Haluatko että sädetän sinut?"
    };

    public override void Interact()
    {
        DialogueSystem.Instance.AddNewDialogue(dialogue, ufoName);
    }
}
