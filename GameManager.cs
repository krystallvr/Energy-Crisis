using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    bool gamehasEnded = false;
    public float restartDelay = 2.0f;


    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void GameOver()
    {
        //Debug.Log("Game Over");
        //Ensures game ends only once
        if (!gamehasEnded)
        {
            gamehasEnded = true;
            SceneManager.LoadScene("Game Over");
        }
    }

    //Might need fixing currently jumps to level 2
    public void LoadPreviousScene()
    {
        if (SceneManager.GetActiveScene().buildIndex > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            //add delay later
        }
        else RestartScene();
    }

    //restarts current scene
    public void RestartScene()
    {
        //restarts current screen
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Quit Game
    public void QuitGame()
    {
        Application.Quit();
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
