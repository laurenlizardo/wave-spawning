using UnityEngine;

public class Enemy : MonoBehaviour
{
  private void OnEnable()
  {
    EnemyManager.Instance.IncrementEnemyCount(1);
  }

  private void OnDisable()
  {
    EnemyManager.Instance.IncrementEnemyCount(-1);
  }
}