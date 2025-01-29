using UnityEngine;

    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager Instance { get; set; }

        public int score;

        public void Awake()
        {
            Instance = this;
        }

    }



