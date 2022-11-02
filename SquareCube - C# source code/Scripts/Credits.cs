using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
     void Start()
    {
        GameManager.UnlockedAllLevels = true;
    }
    public void Quit ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void MENU()

    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1; 
    }
}
