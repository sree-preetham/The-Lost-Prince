using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void retry()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void exit()
    {
         #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
         #else
         Application.Quit();
         #endif
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void start()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
