using UnityEngine;
/// <summary>
/// N‰ytt‰‰ Game Over tekstin
/// </summary>
public class GameOverDisplay : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    private void OnEnable()
    {
        // Luokka kuuntelee OnHealthChange tapahtumaa ja reagoi siihen
        HealthManager.onHealthChange += DisplayGameOver;
    }
    private void OnDisable()
    {
        // Luokka ei kuuntele en‰‰ OnHealthChange tapahtumaa
        HealthManager.onHealthChange -= DisplayGameOver;
    }
    // Metodi suoritetaan kun tapahtuma k‰ynnistyy.
    void DisplayGameOver()
    {
        gameOverPanel.SetActive(true);
    }
}