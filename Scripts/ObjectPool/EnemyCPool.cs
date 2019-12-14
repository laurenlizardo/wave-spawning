public class EnemyCPool : GenericObjectPool<EnemyC>
{
  private void Start()
  {
    FillPool(_poolCount);
    if (_isPoolParent) SetPoolParent(this.gameObject);
  }
}