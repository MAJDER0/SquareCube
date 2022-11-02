
using UnityEngine;

public class XYZ : MonoBehaviour
{

    void OnTriggerEnter(Collider collisionInfo)

        
    {
        Debug.Log(collisionInfo.gameObject.tag);

        if(collisionInfo.gameObject.tag == "Player")

        {

            collisionInfo.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        }


        if (collisionInfo.gameObject.tag == "ChangeeSkyy")

        {

            collisionInfo.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        }
    }

}
