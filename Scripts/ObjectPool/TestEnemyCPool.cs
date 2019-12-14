public class TestEnemyCPool : GenericObjectPool<TestEnemyC>
{
  private void Start()
  {
    AddObjectsToPool(_poolCount);
    if (_isPoolParent) SetPoolParent(this.gameObject);
  }
}