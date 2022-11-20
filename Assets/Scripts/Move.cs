using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    private CharacterController controller;
    private bool groundedPlayer;
    private Vector3 playerVelocity;
    private float playerSpeed = 8.0f;
    public Sprite girl1;
    public Sprite girl2;


    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    bool safetySwitch = false;

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
         
        }


        //most likly a better way to do this
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (safetySwitch == false) 
                transform.Rotate(0, 180f, 0);
            safetySwitch = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (safetySwitch == true)
            transform.Rotate(0, 180f, 0);
            safetySwitch = false;
        }



        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<SpriteRenderer>().sprite = girl2;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite= girl1;
        }


        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        controller.Move(move * Time.deltaTime * playerSpeed);



    }
}
