using UnityEngine;

/// <summary>
/// PerusLuokka sisältää yleiset ominaisuudet ja metodit
/// </summary>
public class Character : MonoBehaviour
{
    // hahmon perusominaisuudet

    [field: SerializeField] protected string Name { get; set; }
    [field: SerializeField] protected float Health { get; set; }

    public void TakeDamage(int damageAmount)
    {
        Health -= damageAmount;
        print($"{Name} sai {damageAmount} vahinkoa! terveystilanne {Health}");

    }

    // ylikirjoitettava metodi, joka voidaan koodata aliluokasta uudelleen
    public virtual void Attack()
    {
        Debug.Log($"{Name} hyökkää!");
    }
}
