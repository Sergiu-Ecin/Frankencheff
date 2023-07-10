using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Orders : MonoBehaviour
{
    public List<string> orders;
    public TextMeshProUGUI text;


    private void Start()
    {
        orders = new List<string>
        {
            "Zombie",
            "Headless",
            "FlyingEye"
        };
        

        string randomString = GetRandomString();
        text.text = "L'ordine richiesto è : " + randomString;
    }

    
    void Update()
    {
        
    }
    public string GetRandomString()
    {
        
        int randomIndex = Random.Range(0, orders.Count);

        
        return orders[randomIndex];
    }
}
