using UnityEngine;
/// <summary>
/// Ker‰tt‰v‰ objekti
/// </summary>
public class Collectible : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameObject collectEffect;
    [SerializeField] private int points;
    private void Update()
    {
        // Pyˆritt‰‰ objektia Y-akselin ymp‰ri
        transform.Rotate(0, rotationSpeed, 0);
    }
    // Suoritetaan kun pˆlynimuri (other) tˆrm‰‰ objektiin
    private void OnTriggerEnter(Collider other)
    {
        // Oliko tˆrm‰‰j‰ pˆlyimuri
        if (other.gameObject.CompareTag("Player"))
        {
            // Destroy the collectible
            Destroy(gameObject);
            // Lis‰‰ pisteit‰ --> K‰ynnist‰‰ tapahtuman
            ScoreManager2.Instance.AddScore(points);
            // instantiate the particle effect
            Instantiate(collectEffect, transform.position,
            transform.rotation);
        }
    }
}