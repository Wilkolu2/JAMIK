using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController CharacterController;

    public float movementSpeed = 7.0f;
    public float currentMovementSpeed;
    public Vector3 lastPosition;
    public float maxMovementSpeedOnWalk = 7.0f;
    public float jumpHeight = 7.0f;
    public float jumpHeightNow = 0f;
    public float sprintSpeed = 12.0f;
    public float sensivity = 3.0f;
    public float mouseUpDown = 0.0f;
    public float zakresMyszkiGoraDol = 90.0f;
    public float fastFalling = 0f;
    public bool isSprint;
    public bool isJump;
    public bool isDead = false;
    public float stamina;
    public float maxStamina = 100f;

    

    [SerializeField] private GameObject deathImage;
    [SerializeField] private GameObject deathButton;

    // Use this for initialization
    void Start()
    {
        deathImage.SetActive(false);
        deathButton.SetActive(false);
        stamina = maxStamina;
        isSprint = false;
        CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isSprint == false)
        {
            movementSpeed = maxMovementSpeedOnWalk;
            if(stamina<maxStamina)
            {
                stamina += Time.deltaTime * 5f;
            }
        }
           
        currentMovementSpeed = Vector3.Distance(lastPosition, transform.position) * 100f;
        lastPosition = transform.position;

        if(isDead==false)
        {
            Mouse();
            Keyboard();
        }
        else if(isDead==true)
        {
            deathButton.SetActive(true);
            deathImage.SetActive(true);
        }

        if(stamina<=0)
        {
            isSprint = false;
            sprintSpeed = maxMovementSpeedOnWalk;
        }
        else
        {
            sprintSpeed = 12f;
        }
    }

    private void Keyboard()
    {
        
        float moveWS = Input.GetAxis("Vertical") * movementSpeed;
        float moveAD = Input.GetAxis("Horizontal") * movementSpeed;


        //skakanie
        if (CharacterController.isGrounded && Input.GetButton("Jump"))
        {
           // jumpHeightNow = jumpHeight;
           // isJump = true;
        }
        else if (!CharacterController.isGrounded)
        {
            jumpHeightNow += Physics.gravity.y * (Time.deltaTime + fastFalling);
            isJump = false;
        }


        //bieganie
        if (Input.GetKey("left shift") && stamina > 0)
        {
            isSprint = true;
            stamina -= Time.deltaTime*10f;
            movementSpeed = sprintSpeed;
            
        }
        else if (Input.GetKeyUp("left shift") || stamina <= 0)
        {
            movementSpeed = maxMovementSpeedOnWalk;
            isSprint = false;
        }


        Vector3 move = new Vector3(moveAD, jumpHeightNow, moveWS);
        move = transform.rotation * move;

        CharacterController.Move(move * Time.deltaTime);
    }

    private void Mouse()
    {
        float mouseLeftRight = Input.GetAxis("Mouse X") * sensivity;
        transform.Rotate(0, mouseLeftRight, 0);

        mouseUpDown -= Input.GetAxis("Mouse Y") * sensivity;
        mouseUpDown = Mathf.Clamp(mouseUpDown, -zakresMyszkiGoraDol, zakresMyszkiGoraDol);
        Camera.main.transform.localRotation = Quaternion.Euler(mouseUpDown, 0, 0);
    }
}