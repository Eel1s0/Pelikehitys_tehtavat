
// Tuhoutuvuus
public interface IDamageable2
    {
        float Health { get; set; }
        int Defense { get; set; }

        void Die();
        void TakeDamage(float amount);
        void RestoreHealth(float amount);
    }
