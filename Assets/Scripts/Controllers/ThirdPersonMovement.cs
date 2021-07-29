using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller;

    public AudioSource foots;
    bool m_HasAudioPlayed = false;
    bool isWalking = false;

    public Animator animator;
    public Transform cam;

    public float speed = 6f;
    float smooth = 10f;

    public float turnTime = 0.1f;

    float turnVelocity = 0f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        animator.SetBool("IsWalking", false);
        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y ;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnVelocity,smooth);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            animator.SetBool("IsWalking", true);
            Debug.Log("Walking");
            if(!m_HasAudioPlayed)
            {
                foots.Play();
                m_HasAudioPlayed = true;
            }
            isWalking = true;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);

            
        }
        else
        {
            isWalking = false;
            // Debug.Log("Not walking");
            if(m_HasAudioPlayed)
            {
                foots.Stop();
                m_HasAudioPlayed=false;
            }
            animator.SetBool("IsWalking", false);
        }
      
            

    }
}
