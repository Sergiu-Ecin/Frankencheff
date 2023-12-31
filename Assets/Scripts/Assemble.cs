using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Assemble : AIState
{
    public Assemble(GameObject _player, NavMeshAgent _agent, Transform _body, Transform _eyes, Transform _hands, Transform _legs, Transform _table, Transform _graveyardBody, Transform _graveyardEyes, Transform _graveyardHands, Transform _graveyardLegs, Transform _client) : base(_player, _agent, _body, _eyes, _hands, _legs, _table, _graveyardBody, _graveyardEyes, _graveyardHands, _graveyardLegs, _client)
    {
        name = State.Assemble;
    }

    public override void Start()
    {
       // Debug.Log("assemble start");
        base.Start();
        agent.SetDestination(table.position);

    }
    public override void Update()
    {
       // Debug.Log("assemble up");
       if (Vector3.Distance(table.position, player.transform.position) < 1f)
        {
            nextState = new Client(player, agent, body, eyes, hands, legs, table, graveyardBody, graveyardEyes, graveyardHands, graveyardLegs, client);
            stage = Event.Exit;
            return;
        }
            base.Update();
        
    }
    public override void Exit()
    {
       // Debug.Log("assemble exit");
        base.Exit();
    }
}
