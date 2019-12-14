public class TestEnemyCPool : TestGenericObjectPool<TestEnemyC>
{
  private void Start()
  {
    FillPool(_poolCount);
    if (_isPoolParent) SetPoolParent(this.gameObject);
  }
}