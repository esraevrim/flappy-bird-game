using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    [ContextMenu("Update Score")]
    public void UpdateScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        playerScore = 0;
        scoreText.text = playerScore.ToString();
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }


}
