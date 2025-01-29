using UnityEngine;

public class Warrior : Character
{
    public int SwordDamage { get; private set; }

    public override void Attack()
    {
        Debug.Log($"{Name} hyökkää miekalla");
    }
}
