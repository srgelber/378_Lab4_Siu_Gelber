using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void StoryMenu()
    {
        SceneManager.LoadScene("Story");
    }
}
