using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PickUp : AIState
{
    public PickUp(GameObject _player, NavMeshAgent _agent, Transform _body, Transform _eyes, Transform _hands, Transform _legs, Transform _table, Transform _graveyardBody, Transform _graveyardEyes, Transform _graveyardHands, Transform _graveyardLegs) : base(_player, _agent, _body, _eyes, _hands, _legs, _table, _graveyardBody, _graveyardEyes, _graveyardHands, _graveyardLegs)
    {
        name = State.PickUp;
    }

    public override void Start()
    {
        Debug.Log("pickup start");
        //agent.SetDestination(table.position);
        if (Vector3.Distance(table.position, player.transform.position) < 2 )
        {

        }    
        base.Start();
    }
    public override void Update()
    {
        Debug.Log("pickupdate");
        nextState = new Assemble(player, agent, body, eyes, hands, legs, table, graveyardBody, graveyardEyes, graveyardHands, graveyardLegs);
        base.Update();
    }

    public override void Exit()
    {
        Debug.Log("pixkexit");
        base.Exit();
    }
}
