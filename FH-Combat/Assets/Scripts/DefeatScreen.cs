using UnityEngine;
using UnityEngine.SceneManagement;

public class DefeatScreen : MonoBehaviour
{
   
    public Animator animator;
    
    // Methode, die vom Retry-Button aufgerufen wird
    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ResetAnimatorParameters()
    {
        // Setze den 'victory'-Parameter zurück
        animator.SetBool("Victory", false);
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

    public void QuitGame()
    {
        Debug.Log("Spiel wird beendet..."); // Debug-Log für den Editor
        Application.Quit();
    }
}
