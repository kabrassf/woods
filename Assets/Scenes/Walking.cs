using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    
    public float speed = 6.0f;
    public float walkSpeed = 6.0f;
    public float runSpeed = 12.0f;
    public float rotationSpeed = 0.5f;
    public float gravity = -9.0f;
    public AudioSource step;
    private CharacterController _charController;
    
    void Start()
    {
        _charController = GetComponent<CharacterController>();
        step = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(0, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);

        transform.Rotate(0, deltaX * rotationSpeed, 0);

        // if (Input.GetKey (KeyCode.UpArrow)){
        //     transform.position += transform.forward * Time.deltaTime * speed;
        // } else if (Input.GetKey (KeyCode.DownArrow)){
        //     transform.position += transform.back * Time.deltaTime * speed;
        // } else if (Input.GetKey (KeyCode.LeftArrow)){
        //     transform.position += transform.left * Time.deltaTime * speed;
        // } else (Input.GetKey (KeyCode.RightArrow)){
        //     transform.position += transform.right * Time.deltaTime * speed;
        // }

        if (Input.GetKey (KeyCode.LeftShift)){
            speed = runSpeed;
        } else {
            speed = walkSpeed;
        }
        
        if (_charController.velocity.magnitude > 1.5f && step.isPlaying == false){
            step.volume = Random.Range(0.5f, 1);
            step.pitch = Random.Range(0.65f, 1.1f);
            step.Play();
        }

    }
}
