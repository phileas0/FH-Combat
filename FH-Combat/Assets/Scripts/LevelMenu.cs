using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button[] levelButtons; // Assign your level buttons in the Inspector

    void Start()
    {
        // Check the player's progress from PlayerPrefs
        int unlockedLevels = PlayerPrefs.GetInt("UnlockedLevels", 1); // Default is 1 (only Level 1 unlocked)

        // Loop through the buttons and enable/disable them based on the unlocked levels
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > unlockedLevels)
            {
                levelButtons[i].interactable = false; // Disable the button if the level is locked
            }
            else
            {
                levelButtons[i].interactable = true; // Enable the button if the level is unlocked
            }
        }
    }

    // Method to load a level
    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Method to unlock the next level (call this when a boss is defeated)
    public static void UnlockNextLevel(int completedLevel)
    {
        int unlockedLevels = PlayerPrefs.GetInt("UnlockedLevels", 1);

        if (completedLevel >= unlockedLevels)
        {
            PlayerPrefs.SetInt("UnlockedLevels", completedLevel + 1);
            PlayerPrefs.Save();
        }
    }
}

