using UnityEngine;

public class BoostsNsL : MonoBehaviour
{
    public PlayerMovement Player;

    private float SpeedBefore;

    private bool ApplySpeed = false;

    private void OnTriggerEnter()
    {

        SpeedBefore = Player.forwardforce; 

        Player.forwardforce += 15000;

        ApplySpeed = true;

        Player.ApplyForce = false;

    }

    private void Update()
    {
        if(Player.forwardforce>SpeedBefore&&ApplySpeed==true)
        {

            Player.forwardforce  -= 15000 * Time.deltaTime;
                     
        }     

        if(Player.forwardforce<=SpeedBefore)
        {
            ApplySpeed = false;

            Player.ApplyForce = true;

            Player.forwardforce = SpeedBefore;
        }

    }

}
