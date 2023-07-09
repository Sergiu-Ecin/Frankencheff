using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiController : MonoBehaviour
{
    [SerializeField] Transform body;
    [SerializeField] Transform eyes;
    [SerializeField] Transform hands;
    [SerializeField] Transform legs;
    [SerializeField] Transform table;
    [SerializeField] Transform graveyardBody;
    [SerializeField] Transform graveyardEyes;
    [SerializeField] Transform graveyardHands;
    [SerializeField] Transform graveyardLegs;
    NavMeshAgent agent;
    AIState currentState;


    private void Start()
    {
        agent = transform.GetComponent<NavMeshAgent>();
        
        currentState = new Idle(this.gameObject, agent, body, eyes, hands, legs, table, graveyardBody, graveyardEyes, graveyardHands, graveyardLegs);
    }

    private void Update()
    {
        currentState = currentState.Process();
        //Debug.Log(currentState.name);
    }
}
