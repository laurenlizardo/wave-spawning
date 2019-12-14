using UnityEngine;

public class TestEnemyB : TestEnemy
{
  public override GameObject NextPoolObject()
  {
    return EnemyBPool.Instance.NextPoolObject().gameObject;
  }
}