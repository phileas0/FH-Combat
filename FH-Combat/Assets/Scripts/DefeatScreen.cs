using UnityEngine;
using UnityEngine.SceneManagement;

public class DefeatScreen : MonoBehaviour
{
   
    // Methode, die vom Retry-Button aufgerufen wird
    public void RetryLevel()
    {
        // Aktuelles Level neu laden
        Scene currentScene = SceneManager.GetActiveScene();

        // Animator für Player und Enemy suchen
        Animator playerAnimator = GameObject.Find("Player").GetComponent<Animator>();
        Animator enemyAnimator = GameObject.Find("Enemy").GetComponent<Animator>();

        // Animator-Parameter zurücksetzen
        if (playerAnimator != null)
        {
            playerAnimator.SetBool("Victory", false); // Setze Victory-Variable auf false
        }

        if (enemyAnimator != null)
        {
            enemyAnimator.SetBool("KB_Stretch", false); // Setze Victory-Variable auf false
            enemyAnimator.Play("KB_Idle_1", -1, 0f);
        }

        // Level neu laden
        SceneManager.LoadScene(currentScene.buildIndex);
        Time.timeScale = 1f; // Spielzeit zurücksetzen
    }


    // Methode, die vom Main Menu-Button aufgerufen wird
    public void GoToMainMenu()
    {
        // Hauptmenü-Szene laden
        SceneManager.LoadScene("MainMenu"); // Stelle sicher, dass deine Main Menu-Szene genau diesen Namen hat
        Time.timeScale = 1f; // Spielzeit zurücksetzen
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Leveldes3");
    }
}
