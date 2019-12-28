public class TestEnemyAPool : GenericObjectPool<TestEnemyA>
{
  private void Start()
  {
    AddObjectsToPool(_poolCount);
    if (_isPoolParent) SetPoolParent(this.gameObject);
  }
}