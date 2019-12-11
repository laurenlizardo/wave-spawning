using UnityEngine;

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
}