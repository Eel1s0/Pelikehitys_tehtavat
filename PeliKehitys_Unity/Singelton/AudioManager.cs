using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

     
    public void Awake()
    {
        Instance = this;
    }

    public void PlaySound(AudioClip clip)
    {
        print($"Soittaa ‰‰nen; {clip.name}");
    }

    public void StopSound()
    {
        print("Pys‰ytt‰‰ ‰‰nen");

    }

}
