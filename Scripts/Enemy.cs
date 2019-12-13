using UnityEngine;

public class Enemy : MonoBehaviour
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
}