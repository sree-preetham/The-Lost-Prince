using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Dodge_Hit_Die : MonoBehaviour
{
    public int currentHealth;
    int dead=0;
    public int maxHealth = 100;
    public HealthBar healthbar;
    public static bool GameIsPaused=false;
    public Animator m_Animator;
    public EnemyController m_Enemy;
    public GameObject pauseMenuUI;
    public AudioSource end;
    float timer = 0;
bool timerReached = false;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
   
    }


    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(20);
            m_Animator.SetTrigger("Hit");
        }*/
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            m_Animator.SetTrigger("Dodge");
        }
        
    }
     

    
    public void takeDamage(int damage)
    {
  
        m_Animator.SetTrigger("Hit");
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
       
        if(currentHealth<=0)
        {
            currentHealth = 0;
            m_Animator.SetTrigger("Die");           
                die();
                end.Play();           
        }
        
    }
    public void die()
    {
        SceneManager.LoadScene("GameOver");
    }
}

