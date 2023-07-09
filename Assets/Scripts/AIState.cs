using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum State
{
    Idle,
    PickUp,
    Assemble
}

public enum Event
{
    Start,
    Update,
    Exit
}
public class AIState 
{
    public State name; // nome dello stato
    protected Event stage; // nome dell'enum event
    protected GameObject player; //
    protected NavMeshAgent agent; // fa muovere il player
    protected AIState nextState; // cambiare i vari stati
    protected Transform body;
    protected Transform eyes;
    protected Transform hands;
    protected Transform legs;
    protected Transform table;
    protected Transform graveyardBody;
    protected Transform graveyardEyes;
    protected Transform graveyardHands;
    protected Transform graveyardLegs;

    public AIState(GameObject _player, NavMeshAgent _agent, Transform _body, Transform _eyes, Transform _hands, Transform _legs, Transform _table, Transform _graveyardBody, Transform _graveyardEyes, Transform _graveyardHands, Transform _graveyardLegs)
    {
        stage = Event.Start;
        player = _player;
        agent = _agent;
        body = _body;
        eyes = _eyes;
        hands = _hands;
        legs = _legs;
        table = _table;
        graveyardBody = _graveyardBody;
        graveyardEyes = _graveyardEyes;
        graveyardHands = _graveyardHands;
        graveyardLegs = _graveyardLegs;
    }
    
    public virtual void Start() { stage = Event.Update; }
    public virtual void Update() {  }
    public virtual void Exit() { stage = Event.Exit;}

    public AIState Process()
    {
        if (stage == Event.Start) Start();
        else if (stage == Event.Update) Update();
        else if (stage == Event.Exit)
        {
            Exit();
            return nextState;
        }

        return this;
    }

}

