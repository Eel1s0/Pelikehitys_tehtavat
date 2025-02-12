using UnityEngine;

public class Mouse1 : MonoBehaviour, IDamageable
{

    [SerializeField] private GameObject explosion;
    [SerializeField] private int HP = 20;
    public void TakeDamage(int amount)
    {
        
        HP -= amount;
        if (HP <= 0)
        {
            Debug.Log("Hiiri tuhottu");
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity); // Räjähdysefekti
        }
    }

}
