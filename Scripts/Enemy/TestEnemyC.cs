using UnityEngine;

public class TestEnemyC : TestEnemy
{
  public override GameObject NextPoolObject()
  {
    return TestEnemyCPool.Instance.NextPoolObject().gameObject;
  }
}