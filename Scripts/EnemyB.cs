using UnityEngine;

public class EnemyB : Enemy
{
  public override GameObject NextPoolObject()
  {
    return EnemyBPool.Instance.NextPoolObject().gameObject;
  }
}