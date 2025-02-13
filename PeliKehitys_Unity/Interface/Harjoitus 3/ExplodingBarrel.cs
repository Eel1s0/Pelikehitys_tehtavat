using UnityEngine;

public class ExplodingBarrel : MonoBehaviour, IDamageable2, IExplodable
{
    public float Health { get; set; } = 50f;
    public int Defense { get; set; } = 0;

    public float Mass { get; set; } = 10f;
    public float ExplosiveForce { get; set; } = 500f;
    public float FuseDelay { get; set; } = 3f;

    public void Die() { Explode(); }
    public void TakeDamage(float amount)
    {
        Health -= amount;
        if (Health <= 0) Die();
    }
    public void RestoreHealth(float amount) { Health += amount; }

    public void Explode() { Debug.Log("Barrel exploded!"); }
}

