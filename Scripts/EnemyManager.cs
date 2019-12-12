using UnityEngine;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour
{
#region Singleton Pattern
  private static EnemyManager _instance;
  public static EnemyManager Instance => _instance;

  private void Awake()
  {
    if (_instance == null) _instance = this;
    else Destroy(gameObject);
  }
#endregion

  private static int _enemyCount;
  public static int EnemyCount => _enemyCount;

  private bool EnemiesPresent => _enemyCount == 0;

  public void IncrementEnemyCount(int increment)
  {
    _enemyCount += increment;
  }

  public GameObject EnemyA;
  public GameObject EnemyB;
  public GameObject EnemyC;

  private void Start()
  {
    CreateSpawnList(EnemyA);
    CreateSpawnList(EnemyB);
    CreateSpawnList(EnemyC);
  }

  private List<GameObject> CreateSpawnList(GameObject prefab)
  {
    List<GameObject> spawnList = new List<GameObject>();
    for (int i = 0; i < _enemyCount; i++)
    {
      spawnList.Add(prefab);
    }
    return spawnList;
  }
}