using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
/// <summary>
/// Aiheuttaa pelaajalle vahinkoa ja lisää pelaajan pisteitä
/// </summary>
public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform player;
    private void Update()
    {
        var eKey = Keyboard.current.eKey.wasPressedThisFrame;
        var rKey = Keyboard.current.rKey.wasPressedThisFrame;
        if (eKey)
        {
            if (HealthManager.Instance != null)
            {
                HealthManager.Instance.TakeDamage(10);
            }
        }
        if (rKey)
        {
            if (ScoreManager2.Instance != null)
            {
                ScoreManager2.Instance.AddScore(10f);
            }
        }
    }
    // Hiiri törmää pölynimuriin
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager2.Instance.AddScore(-1f);
        }
    }
}
