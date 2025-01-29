using UnityEngine;
using UnityEngine.InputSystem;

public class ScoreController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.tKey.wasPressedThisFrame)
        {
            ScoreManager.Instance.score += 10;
            Debug.Log(ScoreManager.Instance.score);
        }
    }
}
