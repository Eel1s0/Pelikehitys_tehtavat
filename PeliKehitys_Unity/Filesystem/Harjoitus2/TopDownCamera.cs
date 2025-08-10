using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    public Transform player;
    public float height = 10f;

    private void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y + height, player.position.z);
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
}
