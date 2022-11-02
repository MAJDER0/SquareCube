using System.Collections;
using UnityEngine;

public class RandomSpawning2 : MonoBehaviour
{
    public GameObject theObstaclee;
    public int xPos;
    public int zPos;
    public int ObstacleCountt;

    void Start()
    {
        StartCoroutine(EnemyyDrop());

    }

    
    IEnumerator EnemyyDrop()
    {
        while (ObstacleCountt < 15)
        {
            xPos = Random.Range(-8, 5);
            zPos = Random.Range(3500, 3780);
            Instantiate(theObstaclee, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            ObstacleCountt += 1;

        }


    }

}
