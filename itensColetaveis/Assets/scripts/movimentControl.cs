using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class movimentControl : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 5f;
    
    public Animator animator;

    public void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Update()
    {
      
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 direction = new Vector3 (horizontal, 0, vertical);
            if (direction.magnitude > 0.1f)
            {

                characterController.Move(transform.forward * vertical * speed * Time.deltaTime);
                float rotationSpeed = speed * 50;
                transform.Rotate(new Vector3(0, horizontal * rotationSpeed * Time.deltaTime, 0));

                animator.SetBool("canWalk", true);
            }
            else
            {
                animator.SetBool("canWalk", false);
            }

                      
        }
    }

