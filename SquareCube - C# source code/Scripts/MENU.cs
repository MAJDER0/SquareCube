using UnityEngine;
using UnityEngine.SceneManagement;
public class MENU : MonoBehaviour
{
    public GameObject BackToLevelButton;

    void Start()
    {

        if(GameManager.UnlockedAllLevels)
      {
            BackToLevelButton.SetActive(true); 

        }  
        
        else
        {

            BackToLevelButton.SetActive(false);

        }
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

    }


}
