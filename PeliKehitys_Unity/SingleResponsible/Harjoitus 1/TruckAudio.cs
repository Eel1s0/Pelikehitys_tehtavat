using UnityEngine;

public class TruckAudio : MonoBehaviour
{
    private AudioSource bounceSound;

    private void Start()
    {
        bounceSound = GetComponent<AudioSource>();
    }

    public void HandleAudio()
    {
        bounceSound.Play();
    }
}
