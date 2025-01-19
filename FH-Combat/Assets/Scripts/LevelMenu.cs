using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    // Die h�chste freigeschaltete Levelnummer (ohne Speicherung)
    // private int unlockedLevel = 1;

    // Diese Methode l�dt die ausgew�hlte Level-Szene, wenn der Button angeklickt wird
    /* public void LoadLevel(int levelNumber)
     {

         if (levelNumber <= unlockedLevel)
         {
             SceneManager.LoadScene("Leveldes" + levelNumber); // Szene basierend auf der Levelnummer laden

         }
         else
         {
             Debug.Log("Dieses Level ist noch gesperrt!");
         }
     }*/
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Leveldes1"); // Szene basierend auf der Levelnummer laden

        /*if (levelNumber <= unlockedLevel)
        {
            f�g obere logik hierhin
        }
        else
        {
            Debug.Log("Dieses Level ist noch gesperrt!");
        }*/
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Leveldes2"); // Szene basierend auf der Levelnummer laden

        /*if (levelNumber <= unlockedLevel)
        {
            f�g obere logik hierhin
        }
        else
        {
            Debug.Log("Dieses Level ist noch gesperrt!");
        }*/
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Leveldes3"); // Szene basierend auf der Levelnummer laden

        /*if (levelNumber <= unlockedLevel)
        {
            f�g obere logik hierhin
        }
        else
        {
            Debug.Log("Dieses Level ist noch gesperrt!");
        }*/
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Diese Methode wird aufgerufen, wenn der Spieler das aktuelle Level beendet (z.B. nach einem Sieg)
    /*public void CompleteCurrentLevel()
    {
        if (unlockedLevel < 5) 
        {
            unlockedLevel++;
        }

        Debug.Log("N�chstes Level freigeschaltet: " + unlockedLevel);

        // Direkt ins n�chste Level wechseln
        SceneManager.LoadScene("Level" + unlockedLevel);
    }*/
}

