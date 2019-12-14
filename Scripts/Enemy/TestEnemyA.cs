using UnityEngine;

public class TestEnemyA : TestEnemy
{
  public override GameObject NextPoolObject()
  {
    return TestEnemyAPool.Instance.NextPoolObject().gameObject;
  }
}