using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public float Delay = 0.5f;
    private string scene;

    public void ExitScene()
    {
        Application.Quit();
    }

    public void LoadScene(string NextScene)
    {
        scene = NextScene;
        Invoke("Load", Delay);
    }

    private void Load()
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadMainMenu()
    {
        Invoke("LMM", 3f);
    }

    private void LMM()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
