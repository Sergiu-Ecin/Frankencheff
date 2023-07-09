using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Assemble : AIState
{
    public Assemble(GameObject _player, NavMeshAgent _agent, Transform _body, Transform _eyes, Transform _hands, Transform _legs, Transform _table, Transform _graveyardBody, Transform _graveyardEyes, Transform _graveyardHands, Transform _graveyardLegs) : base(_player, _agent, _body, _eyes, _hands, _legs, _table, _graveyardBody, _graveyardEyes, _graveyardHands, _graveyardLegs)
    {
        name = State.Assemble;
    }

    public override void Start()
    {
        Debug.Log("assemble start");
        base.Start();
    }
    public override void Update()
    {
        Debug.Log("assemble up");
        base.Update();
        nextState = new PickUp(player, agent, body, eyes, hands, legs, table, graveyardBody, graveyardEyes, graveyardHands, graveyardLegs);
        stage = Event.Exit;
        return;
    }
    public override void Exit()
    {
        Debug.Log("assemble exit");
        base.Exit();
    }
}
