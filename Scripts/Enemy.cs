using UnityEngine;

public abstract class Enemy<T> : MonoBehaviour where T : Component
{
  public static int EnemyCount;

  private void OnEnable()
  {
    EnemyCount++;
  }

  private void OnDisable()
  {
    EnemyCount--;
  }

  public abstract ObjectPool<T> ObjectPooler();
}