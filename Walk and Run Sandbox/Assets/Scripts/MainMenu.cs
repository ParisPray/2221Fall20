using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class MainMenu : MonoBehaviour
{
    public GameObject panel;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + (1));
        
    }
    
    public void ExitGame() 
    {
        Application.Quit();
    }
}
