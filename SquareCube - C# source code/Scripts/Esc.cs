using UnityEngine;


public class Esc : MonoBehaviour
{

    public GameObject ESCAPEcan;

     void Update()
     
        
    {
       
        if (Input.GetKeyDown(KeyCode.Escape))

        {

            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;

                ESCAPEcan.SetActive(true);
            }

            else

            {
                Time.timeScale = 1;
                ESCAPEcan.SetActive(false);
            }
        }


        
    }
       
    
}
