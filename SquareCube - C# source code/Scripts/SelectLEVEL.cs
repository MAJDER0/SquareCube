using UnityEngine.SceneManagement;
using UnityEngine;

public class SelectLEVEL : MonoBehaviour
{
    public void LevelLoad(int index)
    {

        SceneManager.LoadScene(index);
    
    
    }
    
}
