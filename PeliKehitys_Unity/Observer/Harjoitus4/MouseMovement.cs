using UnityEngine;
using UnityEngine.AI;
public class MouseMovement : MonoBehaviour
{
    private NavMeshAgent agent; [SerializeField] private Transform player;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.SetDestination(player.position);
    }
}