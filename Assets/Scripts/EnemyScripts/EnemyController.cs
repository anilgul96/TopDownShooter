using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : Enemy
{
    NavMeshAgent agent;
    public Transform goal;

    private void Start()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(goal.position);//belirlediðimiz positiona gitmesini saðlar
    }
}
