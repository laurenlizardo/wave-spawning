using UnityEngine;

public class TestEnemyB : TestEnemy
{
  public override GameObject NextPoolObject()
  {
    return TestEnemyBPool.Instance.NextPoolObject().gameObject;
  }
}