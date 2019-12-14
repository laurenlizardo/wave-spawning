using UnityEngine;

public class TestEnemyC : TestEnemy
{
  public override GameObject NextPoolObject()
  {
    return EnemyCPool.Instance.NextPoolObject().gameObject;
  }
}