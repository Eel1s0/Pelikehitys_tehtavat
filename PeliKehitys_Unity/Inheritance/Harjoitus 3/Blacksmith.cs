using UnityEngine;

public class Blacksmith : Npc
{
    private void Start()
    {
        npcName = "Sepp�";
        dialogue = new string[]
        {
            "Terve, matkailija! N�yt�t tarvitsevan vahvempaa asetta.",
            "Voin takoa sinulle uuden, jos tuot minulle rautaharkkoja.",
            "Kiinnostaako diili?"
        };
    }
}
