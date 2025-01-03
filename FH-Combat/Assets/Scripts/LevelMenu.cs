using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    // Die höchste freigeschaltete Levelnummer (ohne Speicherung)
    // private int unlockedLevel = 1;

    // Diese Methode lädt die ausgewählte Level-Szene, wenn der Button angeklickt wird
    public void LoadLevel(int levelNumber)
    {
        SceneManager.LoadScene("Level" + levelNumber); // Szene basierend auf der Levelnummer laden

        /*if (levelNumber <= unlockedLevel)
        {
            füg obere logik hierhin
        }
        else
        {
            Debug.Log("Dieses Level ist noch gesperrt!");
        }*/
    }

    // Diese Methode wird aufgerufen, wenn der Spieler das aktuelle Level beendet (z.B. nach einem Sieg)
    /*public void CompleteCurrentLevel()
    {
        if (unlockedLevel < 5) 
        {
            unlockedLevel++;
        }

        Debug.Log("Nächstes Level freigeschaltet: " + unlockedLevel);

        // Direkt ins nächste Level wechseln
        SceneManager.LoadScene("Level" + unlockedLevel);
    }*/
}

