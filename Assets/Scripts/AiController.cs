using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    [SerializeField] Transform client;
    NavMeshAgent agent;
    AIState currentState;
    public TextMeshProUGUI text;
    public static List<string> orders;


    private void Start()
    {
        agent = transform.GetComponent<NavMeshAgent>();

        orders = new List<string>
        {
            "Zombie",
            "Headless",
            "FlyingEye"
        };
        string randomString = GetRandomString();

        text.text = "L'ordine richiesto è : " + randomString;
        currentState = new Idle(this.gameObject, agent, body, eyes, hands, legs, table, graveyardBody, graveyardEyes, graveyardHands, graveyardLegs, client);
    }

    private void Update()
    {
        currentState = currentState.Process();
        //Debug.Log(currentState.name);
    }

    public string GetRandomString()
    {

        int randomIndex = Random.Range(0, orders.Count);


        return orders[randomIndex];
    }
}
