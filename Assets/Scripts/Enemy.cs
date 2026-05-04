using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public float patrolRadius;
    public Vector3 StartPosition;
    private void Start()
    {
        StartPosition = transform.position;

    }
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceToPlayer < 5f)
        {
            agent.SetDestination(player.position);
        }
        else
        {
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                SetNewPatrolPoint();
            }
        }
    }
    private void SetNewPatrolPoint()
    {
        Vector2 randomCircle = Random.insideUnitCircle * patrolRadius;
        Vector3 randompoint= StartPosition+new Vector3(randomCircle.x,0,randomCircle.y);
        if (NavMesh.SamplePosition(randompoint, out NavMeshHit hit, patrolRadius, NavMesh.AllAreas))
        {
            agent.SetDestination(hit.position);
        }
    }
        
    }

