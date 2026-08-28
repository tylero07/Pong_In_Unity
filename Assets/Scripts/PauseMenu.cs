using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PauseMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject PausePanel;
    public static bool isPaused = false;
    // Update is called once per frame
    private void Start()
    {
        PausePanel.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
