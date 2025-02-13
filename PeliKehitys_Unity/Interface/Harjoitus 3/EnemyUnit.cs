using UnityEngine;

public class EnemyUnit : MonoBehaviour, IMovable2, IUnitStats, IDamageable2
{
    public float MoveSpeed { get; set; } = 5f;
    public float Acceleration { get; set; } = 2f;

    public int Strength { get; set; } = 10;
    public int Dexterity { get; set; } = 8;
    public int Endurance { get; set; } = 12;

    public float Health { get; set; } = 100f;
    public int Defense { get; set; } = 5;

    public void GoForward() { Debug.Log("Enemy moving forward"); }
    public void Reverse() { Debug.Log("Enemy reversing"); }
    public void TurnLeft() { Debug.Log("Enemy turning left"); }
    public void TurnRight() { Debug.Log("Enemy turning right"); }

    public void Die() { Debug.Log("Enemy died"); }
    public void TakeDamage(float amount)
    {
        Health -= amount - Defense;
        if (Health <= 0) Die();
    }
    public void RestoreHealth(float amount) { Health += amount; }
}
