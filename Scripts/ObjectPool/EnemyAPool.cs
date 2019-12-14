public class EnemyAPool : GenericObjectPool<EnemyA>
{
  private void Start()
  {
    FillPool(_poolCount);
    if (_isPoolParent) SetPoolParent(this.gameObject);
  }
}