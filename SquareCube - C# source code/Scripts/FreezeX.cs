using UnityEngine;


public class FreezeX : MonoBehaviour
{

    void OnTriggerEnter(Collider CollisionFreeze)

    {
        

        if (CollisionFreeze.gameObject.tag == "ChangeeSkyy")

        {
            
            CollisionFreeze.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            
        }
    }


}
