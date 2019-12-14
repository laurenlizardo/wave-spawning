using UnityEngine;

public abstract class Enemy : MonoBehaviour
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

  public abstract GameObject NextPoolObject();
}