
using UnityEngine;

public class GroundCH : MonoBehaviour
{
    public void OnTriggerEnter(Collider skychange)

    {


        if (skychange.gameObject.tag == "ChangeeSkyy")
        {

           
            RenderSettings.ambientLight = Color.black;
            Light lt= skychange.gameObject.GetComponentInChildren<Light>();
            lt.type = LightType.Spot;
            lt.intensity = 5;

        }



    }
}
