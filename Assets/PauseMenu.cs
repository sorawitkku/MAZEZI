using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject pauseMenu;

    private bool IsPause;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !IsPause)
        {
            Pause();
            IsPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && IsPause)
        {
            ExitPause();
            IsPause = false;
        }


    }

    public void ExitPause()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

}