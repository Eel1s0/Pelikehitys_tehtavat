using UnityEngine;

public class PlayerAudio1 : MonoBehaviour
{
    private AudioSource collisionSound;

    private void Start()
    {
        collisionSound = GetComponent<AudioSource>();
    }

    public void HandleCollisionAudio()
    {
        collisionSound.Play();
    }
}
