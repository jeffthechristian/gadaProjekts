using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public CharacterController controller;
    public AudioSource BackgroundMusic;
   
    float xRotation = 0f;
    public float movementSpeed = 4f;
    public float mouseSensitivity = 100;

    public Vector2 turn;

    Vector3 velocity;

    //Make background music play at start
    //Lock cursor so it isn't visible
    void Start() {
        BackgroundMusic.Play();
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update() {
        //Make player object move
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        controller.Move((transform.right * x + transform.forward * z) * movementSpeed * Time.deltaTime);

        //camera rotation
        turn.x += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        turn.y = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= turn.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, turn.x, 0);
    }
}