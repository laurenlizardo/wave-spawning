using UnityEngine;

public class TestEnemyA : TestEnemy
{
  public override GameObject NextPoolObject()
  {
    return EnemyAPool.Instance.NextPoolObject().gameObject;
  }
}