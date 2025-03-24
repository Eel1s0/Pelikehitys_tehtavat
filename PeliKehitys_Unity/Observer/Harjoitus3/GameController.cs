using UnityEngine;
using UnityEngine.SceneManagement;
using static HealthManager;
public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject startGamePanel;
    private void OnEnable()
    {
        HealthManager.onHealthChange += RestartGame;
    }
    private void OnDisable()
    {
        HealthManager.onHealthChange -= RestartGame;
    }
    private void RestartGame()
    {
        startGamePanel.SetActive(true);
    }
    public void StartNewGame()
    {
        SceneManager.LoadScene("Events");
    }
}