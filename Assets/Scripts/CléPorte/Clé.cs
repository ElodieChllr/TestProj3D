using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Clé : MonoBehaviour
{

    PlayerInput playerInputRef;
    public GameObject player;
    void Start()
    {
        playerInputRef = player.GetComponent<PlayerInput>();
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && playerInputRef.actions["Interagir"].IsPressed())
        {
            Debug.Log("prend");
        }
    }
}
