using UnityEngine;

public class Merchant : Npc
{
    private void Start()
    {
        npcName = "Kauppias";
        dialogue = new string[]
        {
            "Tervetuloa kauppaani, matkailija!",
            "Minulla on kaikkea mitä tarvitset, aseita, ruokaa ja taikajuomia.",
            "Haluatko ostaa jotain?"
        };
    }
}
