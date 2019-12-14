public class TestEnemyBPool : GenericObjectPool<TestEnemyB>
{
  private void Start()
  {
    FillPool(_poolCount);
    if (_isPoolParent) SetPoolParent(this.gameObject);
  }
}