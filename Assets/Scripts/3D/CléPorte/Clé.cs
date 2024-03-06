using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Clé : MonoBehaviour
{

    PlayerInput playerInputRef;
    public GameObject player;

    public GameObject txt_Ramasser;
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
            txt_Ramasser.SetActive(true);
        }
    }
}
