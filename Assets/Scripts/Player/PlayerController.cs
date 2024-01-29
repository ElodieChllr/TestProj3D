using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb_player;

    public float moveSpeed = 5f;

    public PlayerMap playerMap;

    public PlayerInput playerInput;
 
    private void Awake()
    {
        playerMap = new PlayerMap();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = playerMap.Player.Mouvement.ReadValue<Vector3>();
        rb_player.velocity = new Vector3(movement.x * moveSpeed,0, movement.z * moveSpeed);
    }


    private void OnEnable()
    {
        playerMap.Enable();
    }

    private void OnDisable()
    {
        playerMap.Disable();
    }

}
