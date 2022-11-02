using System.Collections;
using UnityEngine;

public class RandomObstacleSpawning : MonoBehaviour
{
    public GameObject theObstacle;
    public int xPos;
    public int zPos;
    public int ObstacleCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());

    }


    IEnumerator EnemyDrop()
  {
        while (ObstacleCount < 15)
        {
            xPos = Random.Range(-8, 5);
            zPos = Random.Range(1280, 1490);
            Instantiate(theObstacle, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            ObstacleCount += 1;

        }


  }
    
}
