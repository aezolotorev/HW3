using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuinGame : MonoBehaviour
{
    string namescene;
    enum Screen
    {
        None,
        Menu,
       
    }

    public CanvasGroup menuScreen;

    private void Start()
    {
        SetCurrentScreen(Screen.None);
        namescene = SceneManager.GetActiveScene().name; 
    }

    void SetCurrentScreen(Screen screen)
    {
        Utility.SetCanvasGroupEnabled(menuScreen, screen == Screen.Menu);
    }

    // Start is called before the first frame update
    public void OpenMenu()
    {
        SetCurrentScreen(Screen.Menu);
        Time.timeScale = 0;
    }

    public void MainMenu()
    {
        SetCurrentScreen(Screen.None);
        LoadingScreen.instance.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void Reset()
    {
        
        LoadingScreen.instance.LoadScene(namescene);
        Time.timeScale = 1;
    }

    public void CloseMenu()
    {
        SetCurrentScreen(Screen.None);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
