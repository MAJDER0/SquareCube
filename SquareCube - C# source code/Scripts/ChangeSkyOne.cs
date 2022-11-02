
using UnityEngine;

public class ChangeSkyOne : MonoBehaviour
{

    public Material skyOne;


    public void OnTriggerEnter(Collider skychange)

    {
        

        if (skychange.gameObject.tag == "ChangeeSkyy") 
        {
            
         RenderSettings.skybox = skyOne;
            RenderSettings.ambientLight = new Color(1f, 1f, 0.9f);
            
            Light lt = skychange.gameObject.GetComponentInChildren<Light>();
            lt.type = LightType.Spot;
            lt.intensity = 0;

        }

        

    }

    
}
