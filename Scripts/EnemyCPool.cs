public class EnemyCPool : ObjectPool<EnemyC>
{
  private void Start()
  {
    FillPool(_poolCount);
    if (_isPoolParent) SetPoolParent(this.gameObject);
  }
}