public class EnemyBPool : ObjectPool<EnemyB>
{
  private void Start()
  {
    FillPool(_poolCount);
    if (_isPoolParent) SetPoolParent(this.gameObject);
  }
}