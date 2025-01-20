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
        SaveProgress();
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

    private void SaveProgress()
    {
        // Lade aktuellen Fortschritt
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);

        // Falls Level 3 noch nicht freigeschaltet ist, freischalten
        if (unlockedLevel < 3)
        {
            unlockedLevel = 3;
            PlayerPrefs.SetInt("UnlockedLevel", unlockedLevel); // Fortschritt speichern
            PlayerPrefs.Save(); // Änderungen dauerhaft speichern
            Debug.Log("Fortschritt gespeichert: " + unlockedLevel);
        }
    }
}
