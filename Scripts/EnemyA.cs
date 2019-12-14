using UnityEngine;

public class EnemyA : Enemy
{
  public override GameObject NextPoolObject()
  {
    return EnemyAPool.Instance.NextPoolObject().gameObject;
  }
}