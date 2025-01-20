using UnityEngine;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    // Update is called once per frame
    public void SkipTutorial()
    {
        SceneManager.LoadScene("LevelMap");
    }
}
