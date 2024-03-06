using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableController : MonoBehaviour
{
    public enum ACTIONS
    {
        NONE,
        TALK,
        PICK,
        DROP,
        USE,
    }

    private Collider _collider;
    public KeyCode keyAction;
    public ACTIONS action;
    public PlayerMap inputMap { get; private set; }

    private void Awake()
    {
        _collider = GetComponent<Collider>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(collision.transform.TryGetComponent<PlayerController>(out var pc))
            {
                Debug.Log("");

            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Exit");
        }
    }
}
