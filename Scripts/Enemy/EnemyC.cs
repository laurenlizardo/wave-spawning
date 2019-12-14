using UnityEngine;

public class EnemyC : Enemy
{
  public override GameObject NextPoolObject()
  {
    return EnemyCPool.Instance.NextPoolObject().gameObject;
  }
}