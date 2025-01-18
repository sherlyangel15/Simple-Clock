using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Main()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadClock()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadStopWatch()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(3);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
