using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject panel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame(); 
            } else
            {
                PauseGame();
            }
        }
    }

    void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        panel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void PauseGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        panel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
