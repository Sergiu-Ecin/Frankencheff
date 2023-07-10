using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public enum State
{
    Idle,
    PickUp,
    Assemble,
    Client
}

public enum Event
{
    Start,
    Update,
    Exit
}
public class AIState 
{
    public List<Vector3> destinations;
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
    protected Transform client;


    public AIState(GameObject _player, NavMeshAgent _agent, Transform _body, Transform _eyes, Transform _hands, Transform _legs, Transform _table, Transform _graveyardBody, Transform _graveyardEyes, Transform _graveyardHands, Transform _graveyardLegs, Transform _client)
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
        client = _client;
    }


    public virtual void Start()
    {
        stage = Event.Update;
        //destinations =new  List<Vector3>();

    }
    public virtual void Update() { }
    public virtual void Exit() { stage = Event.Exit; }

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

    public void MyCoroutine()
    {
        Debug.Log("Coroutine completata.");
    }

    public void ZombieGo()
    {
        destinations.Add(body.position);
        destinations.Add(eyes.position);
        destinations.Add(hands.position);
        destinations.Add(legs.position);
    }

    public void HeadlessGo()
    {
        destinations.Add(hands.position);
        destinations.Add(legs.position);
    }

    public void FlyingEyeGo()
    {
        destinations.Add(hands.position);
        destinations.Add(eyes.position);
    }

}

