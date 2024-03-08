using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("Winner winner breakfast lunch and dinner plates oh arent they great");
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (gameHasEnded == false)
        {
            Debug.Log("Game Over");
            gameHasEnded = true;
            Restart();
        }
        
    }
}
