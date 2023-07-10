using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class PickUp : AIState
{
    //float timer = 0f;
    //AiController controller;
    //string actualOrder;

    public PickUp(GameObject _player, NavMeshAgent _agent, Transform _body, Transform _eyes, Transform _hands, Transform _legs, Transform _table, Transform _graveyardBody, Transform _graveyardEyes, Transform _graveyardHands, Transform _graveyardLegs, Transform _client) : base(_player, _agent, _body, _eyes, _hands, _legs, _table, _graveyardBody, _graveyardEyes, _graveyardHands, _graveyardLegs, _client)
    {
        name = State.PickUp;
    }

    public override void Start()
    {
        agent.SetDestination(body.position);
        //Debug.Log("pickup start");

        //if (Vector3.Distance(table.position, player.transform.position) < 1)
        //{
        //    Debug.Log("Arrivato");
        //}
        //AiController.orders[0] = actualOrder;
        base.Start();
    }
    public override void Update()
    {
        
        if (Vector3.Distance(body.position, player.transform.position) < 1f)
        {
            agent.SetDestination(hands.position);
            
        }
        if (Vector3.Distance(hands.position, player.transform.position) < 1f)
        {
            nextState = new Assemble(player, agent, body, eyes, hands, legs, table, graveyardBody, graveyardEyes, graveyardHands, graveyardLegs, client);
            stage = Event.Exit;
            return;
        }

        //agent.SetDestination(body.position);
        //if (agent.pathEndPosition == body.position)
        //{
        //    timer += Time.deltaTime;
        //    if (timer >= 2f)
        //    {
        //        agent.SetDestination(eyes.position);

        //        timer = 0;
        //        return;
        //    }
        //}
        //if (actualOrder == "Zombie")
        //{
        //    Debug.Log(actualOrder);
        //    
        //    agent.SetDestination(destinations[0]);
        //    if (agent.pathEndPosition == destinations[0])
        //    {
        //        destinations[0] = destinations[1];
        //    }
        //}
        //switch (actualOrder)
        //{
        //    case 0:
        //        ()
        //        {
        //            ZombieGo();
        //        }
        //        break;

        //    case 1:
        //        ()
        //        {

        //        }
        //        break;

        //    case 2:
        //        (actualOrder == "FlyingEye")
        //    {

        //        }
        //        break;

        //}
        base.Update();
        
    }

    public override void Exit()
    {
        // Debug.Log("pickup exit");
        base.Exit();
    }
}
