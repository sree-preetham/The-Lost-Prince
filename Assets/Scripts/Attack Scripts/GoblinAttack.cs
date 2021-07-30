using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoblinAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public GoblinController[] goblin;

    public AudioSource attack1;
    public AudioSource attack2;
    public AudioSource attack3;
   

    public Animator animator;
    public float coolDown = 0.5f;
    public float coolDownTimer;
    public Transform[] target;

    public NavMeshAgent agent;

    void Update()
    {
        for(int i = 0; i < target.Length; i++)
        {
        float attack_range = Vector3.Distance(target[i].position, transform.position);
        goblin[i].animator.SetBool("damage", false);
        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }
        else if (coolDownTimer <= 0)
        {
            coolDownTimer = 0;
        }
        if (Input.GetMouseButtonDown(0) && coolDownTimer == 0)
        {
            Attack1();
            coolDownTimer = coolDown;
        }
        else if (Input.GetMouseButtonDown(1) && coolDownTimer == 0)
        {
            Attack2();
            coolDownTimer = coolDown;
        }
        else if (Input.GetMouseButtonDown(2) && coolDownTimer == 0)
        {
            Attack3();
            coolDownTimer = coolDown;
        }
        }
    }
    void Attack1()
    {
        for(int i = 0; i < target.Length; i++)
        {
        float attack_range = Vector3.Distance(target[i].position, transform.position);
        animator.SetTrigger("Attack1");
        attack1.Play();
        if (attack_range <= agent.stoppingDistance)
        {

            goblin[i].TakeDamage();

        }
        }

    }
    void Attack2()
    {
        for(int i = 0; i < target.Length; i++)
        {
        float attack_range = Vector3.Distance(target[i].position, transform.position);
        animator.SetTrigger("Attack2");
        attack2.Play();
        if (attack_range <= agent.stoppingDistance)
        {

            goblin[i].TakeDamage();

        }
        }
    }
    void Attack3()
    {
        for(int i = 0; i < target.Length; i++)
        {
        float attack_range = Vector3.Distance(target[i].position, transform.position);
        animator.SetTrigger("Attack3");
            attack3.Play();
        if (attack_range <= agent.stoppingDistance)
        {

            goblin[i].TakeDamage();

        }
        }
    }
}
