using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public Vector3 offset;
    private PlayerController _player;



    PlayerMap playerMap;

    public PlayerInput playerInput;
    private float rotationSpeed = 2f;
    public Transform cameraPivot;


    private Vector3 _lastMousePos = Vector2.zero;
    private Vector3 _lastPlayerPos = Vector3.zero;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerController>();
        playerMap = new PlayerMap();

    }

    void Start()
    {
        
    }

    
    void Update()
    {
        //RotateCamera();
        //FollowTarget();
        //SetlookAt();



        //FreeRotate();
    }

    //private void FollowTarget()
    //{
    //    Vector3 deltaPlayerPos = _player.transform.position - _lastPlayerPos;
    //    //transform.position = _player.transform.position + offset;
    //    transform.position += deltaPlayerPos;

    //    _lastPlayerPos = _player.transform.position;
    //}

    //private void SetlookAt()
    //{
    //    transform.LookAt(_player.transform);
    //}

    
    //private void FreeRotate()
    //{
    //    Vector3 deltaMousePos = Input.mousePosition - _lastMousePos;

    //    transform.RotateAround(_player.transform.position, Vector3.up, deltaMousePos.x);
    //    transform.RotateAround(_player.transform.position, Vector3.left, deltaMousePos.y);

    //    transform.localRotation = Quaternion.AngleAxis(Mathf.Clamp(transform.localEulerAngles.y, -10, 10), Vector3.up);
    //    //transform.eulerAngles.Set(transform.eulerAngles.x, Mathf.Clamp(transform.eulerAngles.y, -45, 45), transform.eulerAngles.z);
    //    _lastMousePos = Input.mousePosition;
    //}

    //public void RotateCamera()
    //{
    //    Vector2 rotationInput = playerMap.Player.Camera.ReadValue<Vector2>();

    //    // Rotation autour de l'axe horizontal (y)
    //    cameraPivot.Rotate(Vector3.up, rotationInput.x * rotationSpeed, Space.World);

    //    // Rotation autour de l'axe vertical (x)
    //    // Utilisation de la rotation locale de la caméra pour éviter les problèmes avec Space.World
    //    cameraPivot.transform.localRotation *= Quaternion.Euler(-rotationInput.y * rotationSpeed, 0f, 0f);
    //}
}
