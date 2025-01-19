using UnityEngine;
using UnityEngine.SceneManagement;

public class DefeatScreen : MonoBehaviour
{
   

    // Methode, die vom Retry-Button aufgerufen wird
    public void RetryLevel()
    {
        // Aktuelles Level neu laden
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f; // Spielzeit zur�cksetzen
    }

    // Methode, die vom Main Menu-Button aufgerufen wird
    public void GoToMainMenu()
    {
        // Hauptmen�-Szene laden
        SceneManager.LoadScene("MainMenu"); // Stelle sicher, dass deine Main Menu-Szene genau diesen Namen hat
        Time.timeScale = 1f; // Spielzeit zur�cksetzen
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Leveldes3");
    }
}
