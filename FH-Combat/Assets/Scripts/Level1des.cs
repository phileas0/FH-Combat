using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1des : MonoBehaviour
{
    private Animator playerAnimator;
    private Animator enemyAnimator;

    void Start()
    {
        // Findet die Animator-Komponenten der Player- und Enemy-GameObjects
        playerAnimator = GameObject.Find("Player")?.GetComponent<Animator>();
        enemyAnimator = GameObject.Find("Enemy")?.GetComponent<Animator>();

        // Setzt die Animatoren zurück
        if (playerAnimator != null)
        {
            playerAnimator.Play(0, -1, 0f);
        }

        if (enemyAnimator != null)
        {
            enemyAnimator.Play(0, -1, 0f);
        }
    }

    public void PlayGame1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void PlayGame2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void PlayGame3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Return()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Leveldes1" || currentScene == "Leveldes2")
        {
            SceneManager.LoadScene("ChooseOpponent");
        }
        else if (currentScene == "ChooseOpponent" || currentScene == "Leveldes3")
        {
            SceneManager.LoadScene("LevelMap");
        }

    }
}
