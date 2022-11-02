
using UnityEngine;

public class DropObject : MonoBehaviour
{
    public Rigidbody klocek;
    private void OnTriggerEnter(Collider Collisiondrop)
    {
        
        if(Collisiondrop.gameObject.tag == "ChangeeSkyy")

        {

            klocek.isKinematic = false; 

        }

    }


}
