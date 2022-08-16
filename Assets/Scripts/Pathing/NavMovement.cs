using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavMovement : Movement
{
    public NavMeshAgent navMeshAgent;
    bool canMove = false;
    float timer;
    public float timeMove = 5;

    public override Vector3 Velocity
    {
        get { return navMeshAgent.velocity; }
        set { navMeshAgent.velocity = value; }
    }

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        //Stop();
    }

    void Update()
    {
        navMeshAgent.speed = speedMax;
        navMeshAgent.angularSpeed = turnRate;
        canMove = true;
        if (canMove)
        {
            timer = timeMove;
            Resume();
        }
    }

    public override void ApplyForce(Vector3 force)
    {
        //
    }

    public override void MoveTowards(Vector3 target)
    {

        navMeshAgent.SetDestination(target);
    }

    //public override void Stop()
    //{
    //    navMeshAgent.isStopped = true;
    //}

    public override void Resume()
    {
        navMeshAgent.isStopped = false;
    }
}
