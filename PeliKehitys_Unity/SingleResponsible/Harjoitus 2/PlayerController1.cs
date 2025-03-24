using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    private PlayerInput1 playerInput;
    private PlayerMovement1 playerMovement;
    private PlayerAudio1 playerAudio;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput1>();
        playerMovement = GetComponent<PlayerMovement1>();
        playerAudio = GetComponent<PlayerAudio1>();
    }

    private void Update()
    {
        playerMovement.MovePlayer(playerInput.HorizontalInput, playerInput.VerticalInput);
    } 

    private void OnTriggerEnter(Collider other)
    {
        playerAudio.HandleCollisionAudio();
        if (other.CompareTag("Interactable Object"))
        {
            Destroy(other.gameObject);
        }
    }
}
