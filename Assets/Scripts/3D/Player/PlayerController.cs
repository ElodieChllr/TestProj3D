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

    private float rotationSpeed = 2f;

    private Transform cameraMainTransform;

    private Vector3 offset;



    public GameObject mainCamera;
    public GameObject photoCamera;

    private void Awake()
    {
        playerMap = new PlayerMap();
        cameraMainTransform = Camera.main.transform;
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move_and_Cam();
       

    }
    


    private void OnEnable()
    {
        playerMap.Enable();
    }

    private void OnDisable()
    {
        playerMap.Disable();
    }

    private void Move_and_Cam() 
    {

        

        Vector3 movement = playerMap.Player.Mouvement.ReadValue<Vector3>();
        rb_player.velocity = new Vector3(movement.x * moveSpeed, 0, movement.z * moveSpeed);


        // Normaliser le vecteur de mouvement pour éviter une vitesse plus élevée en diagonale
        movement.Normalize();

        // Convertir la direction du mouvement par rapport à la direction de la caméra
        movement = Quaternion.Euler(0f, cameraMainTransform.eulerAngles.y, 0f) * movement;

        // Appliquer le mouvement au joueur
        rb_player.velocity = movement * moveSpeed;

        // Rotation du joueur
        if (movement != Vector3.zero)
        {
            float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
            Quaternion targetRotation = Quaternion.Euler(0f, targetAngle, 0f);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        }

        // Suivi de la caméra
        Vector3 desiredPosition = transform.position - offset;
        Vector3 smoothedPosition = Vector3.Lerp(cameraMainTransform.position, desiredPosition, Time.deltaTime * 5f);
        cameraMainTransform.position = smoothedPosition;

        // Regard de la caméra
        Quaternion lookRotation = Quaternion.LookRotation(transform.position - cameraMainTransform.position, Vector3.up);
        cameraMainTransform.rotation = Quaternion.Slerp(cameraMainTransform.rotation, lookRotation, Time.deltaTime * 5f);
    }


    public void OnCamPictures()
    {
        if (playerInput.actions["Photo"].WasPressedThisFrame())
        {
            mainCamera.SetActive(false);
            photoCamera.SetActive(true);

        }
    }

}
