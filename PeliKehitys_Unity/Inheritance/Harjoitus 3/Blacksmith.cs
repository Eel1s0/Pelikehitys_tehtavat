using UnityEngine;

public class Blacksmith : Npc
{
    private void Start()
    {
        npcName = "Seppä";
        dialogue = new string[]
        {
            "Terve, matkailija! Näytät tarvitsevan vahvempaa asetta.",
            "Voin takoa sinulle uuden, jos tuot minulle rautaharkkoja.",
            "Kiinnostaako diili?"
        };
    }
}
