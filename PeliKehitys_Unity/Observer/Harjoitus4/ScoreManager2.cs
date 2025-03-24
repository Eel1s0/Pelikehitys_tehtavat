using TMPro;
using UnityEngine;
/// <summary>
/// Hallinnoi pisteit‰. On sek‰ Kuuntelija ett‰ Tarkkailija
/// </summary>
public class ScoreManager2 : MonoBehaviour
{
    // Singelton
    public static ScoreManager2 Instance { get; set; }
    [SerializeField] private GameObject winPanel;
    [SerializeField] private TMP_Text scoreText;
    private float currentScore;
    private float maxScore = 50f;
    // Delegaatti
    public delegate void OnScoreChange();
    public static OnScoreChange onScoreChange;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        scoreText.text = $"Score: {currentScore} ";
    }
    private void OnEnable()
    {
        onScoreChange += ShowWinnerPanel;
    }
    private void OnDisable()
    {
        onScoreChange -= ShowWinnerPanel;
    }
    // Kasvatetaan pelaajan pisteit‰
    public void AddScore(float score)
    {
        currentScore += score;
        scoreText.text = currentScore.ToString();
        if (currentScore >= maxScore)
        {
            // Tapahtuma k‰ynnistyy (esim. voittopaneli) kun pisteit‰ on ker‰tty 50
        onScoreChange?.Invoke();
        }
    }
    // N‰ytt‰‰ voittopanelin
    private void ShowWinnerPanel()
    {
        winPanel.SetActive(true);
    }
}