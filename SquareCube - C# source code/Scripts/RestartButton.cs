using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour   
{

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.R))

        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }


    }

    
}
