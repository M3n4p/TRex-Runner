using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public List<Transform> obstacles;
    public float timeBetweenSpawns;

    public GameManager manager;

    private void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    IEnumerator SpawnObstacle()
    {
        while(true)
        {
            int prefabIndex = Random.Range(0, obstacles.Count);
            Transform obstacle = Instantiate(obstacles[prefabIndex]);
            obstacle.position = new Vector3(transform.position.x, -1f + (obstacle.localScale.y / 2f), transform.position.z);
            obstacle.SetParent(transform, false);
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }

    private void Update()
    {
        if(manager.IsDead)
        {
            StopAllCoroutines();
        }
    }
}
