public class TestEnemyBPool : GenericObjectPool<TestEnemyB>
{
  private void Start()
  {
    AddObjectsToPool(_poolCount);
    if (_isPoolParent) SetPoolParent(this.gameObject);
  }
}