public class TestEnemyAPool : GenericObjectPool<TestEnemyA>
{
  private void Start()
  {
    FillPool(_poolCount);
    if (_isPoolParent) SetPoolParent(this.gameObject);
  }
}