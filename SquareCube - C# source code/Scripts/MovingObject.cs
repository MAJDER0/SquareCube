using UnityEngine;

public class MovingObject : MonoBehaviour
{
    int speedAmt = 5;

    private void Update()
    {
        if (transform.position.x <= -6.2)
        {

            speedAmt = 5;

        }




        if (transform.position.x >= 3.6)
        {
            speedAmt = -5;
        }

        transform.Translate(speedAmt * Time.deltaTime, 0, 0);

            }

}
