using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenuCanvas;

    private bool isPaused = false;

    void Start()
    {
        pauseMenuCanvas.SetActive(false);
    }

    void Update()
    {
        // �berpr�fen, ob die ESC-Taste gedr�ckt wurde
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenuCanvas.SetActive(false); // Men� ausblenden
        Time.timeScale = 1f; // Spiel fortsetzen
        AudioListener.pause = false;
        isPaused = false;
    }

    public void PauseGame()
    {
        pauseMenuCanvas.SetActive(true); // Men� anzeigen
        Time.timeScale = 0f; // Spiel anhalten
        AudioListener.pause = true;
        isPaused = true;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f; // Zeit wieder normal setzen
        SceneManager.LoadScene("MainMenu"); // Szene f�r das Hauptmen� laden
    }

    public void QuitGame()
    {
        Application.Quit(); // Spiel beenden
    }
}
