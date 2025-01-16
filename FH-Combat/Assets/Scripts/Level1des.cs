using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1des : MonoBehaviour
{
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
        SceneManager.LoadScene("LevelMap");
    }
}
