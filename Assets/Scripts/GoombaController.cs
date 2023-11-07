using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaController : MonoBehaviour
{
    public int COuntPn;
    private SpawnsEnemySystem spawnsEnemySystem;
    public void EnemyHit()
    {
       spawnsEnemySystem.EnemyHit();
    }
}
