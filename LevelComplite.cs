using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplite : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}