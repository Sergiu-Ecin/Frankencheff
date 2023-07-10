using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Client : AIState
{
    public Client(GameObject _player, NavMeshAgent _agent, Transform _body, Transform _eyes, Transform _hands, Transform _legs, Transform _table, Transform _graveyardBody, Transform _graveyardEyes, Transform _graveyardHands, Transform _graveyardLegs, Transform _client) : base(_player, _agent, _body, _eyes, _hands, _legs, _table, _graveyardBody, _graveyardEyes, _graveyardHands, _graveyardLegs, _client)
    {
        name = State.Client;
    }

    public override void Start()
    {
        // Debug.Log("grave start");
        agent.SetDestination(client.position);
        base.Start();
    }
    public override void Update()
    {
        //Debug.Log("grave update");
        if (Vector3.Distance(client.position, player.transform.position) < 1f)
        {
            nextState = new Idle(player, agent, body, eyes, hands, legs, table, graveyardBody, graveyardEyes, graveyardHands, graveyardLegs, client);
            stage = Event.Exit;
            return;
        }
        base.Update();
        
    }

    public override void Exit()
    {
       // Debug.Log("grave exit");
        base.Exit();
    }
}
