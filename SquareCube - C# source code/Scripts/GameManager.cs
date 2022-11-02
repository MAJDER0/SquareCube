using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 
    bool gameHasEnded = false;

    public static bool UnlockedAllLevels = false;

    public float RestartDelay = 1f;

    public GameObject completeLevelUI;

    public void Completelevel ()
    {
        completeLevelUI.SetActive(true);
    }

   public void EndGame()
    {
        if(gameHasEnded == false)

        {
            gameHasEnded = true;

            Debug.Log("GAME OVER");
            Invoke("Restart", RestartDelay);
        }
    }

          void Restart ()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    

}
