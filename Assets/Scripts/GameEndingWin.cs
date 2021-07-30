using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndingWin : MonoBehaviour
{
    public float fadeDuration=1f;
    public GameObject player;
    bool isPlayerExit=false;
    float m_timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isPlayerExit = true;
        }
    }

    void Update()
    {
        if (isPlayerExit)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene("YouWon");
    }
}
