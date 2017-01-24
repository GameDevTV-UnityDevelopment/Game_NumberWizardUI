using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    /// <summary>
    /// Loads the level with the specified name
    /// </summary>
    /// <param name="name">The name of the level to load</param>
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for : " + name);
        SceneManager.LoadScene(name);
    }

    /// <summary>
    /// Quits the game
    /// </summary>
    /// <remarks>Limited functionality on Web and Debug/Editor builds, bad practice for mobile devices</remarks>
    public void QuitRequest()
    {
        Debug.Log("I want to quit!");
        Application.Quit();
    }
}
