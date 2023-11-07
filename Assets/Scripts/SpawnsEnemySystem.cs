using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnsEnemySystem : MonoBehaviour
{
    [SerializeField]
    private Transform[] randomTargetSpawn;
    private int maxEnemyCount = 30;
    [SerializeField]
    private GameObject enemyPrefab;

    private List<GameObject> spawnedEnemies = new List<GameObject>();
    public int COuntPn;
    private bool isPawn = false;

    private void Start()
    {
        SpawnEnemy();
        isPawn = true;
    }

    private void Update()
    {
      
         SpawnEnemy();
          if(COuntPn <=maxEnemyCount)
        {
            isPawn = true;
        }
        Debug.Log(COuntPn);
    }

    private void SpawnEnemy()
    {
        if (isPawn)
        {
            foreach (Transform spawnPoint in randomTargetSpawn)
            {
                GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
                spawnedEnemies.Add(enemy);
                COuntPn++;
                
            }
        }

        if(COuntPn >= maxEnemyCount)
        {
            isPawn=false;
        }
       
    }
    public void EnemyHit()
    {
        COuntPn--;
    }

}