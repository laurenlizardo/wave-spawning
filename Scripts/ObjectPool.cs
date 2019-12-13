using UnityEngine;
using System.Collections.Generic;

public abstract class ObjectPool<T> : MonoBehaviour where T : Component
{
  [SerializeField] private protected T _prefab;
  [SerializeField] private protected int _poolCount;
  [SerializeField] private protected bool _isPoolParent;
  private Queue<T> _objectPool = new Queue<T>();
  public Transform Spawnpoint;

#region Object Pooling Methods
  protected void FillPool(int count)
  {
    for (int i = 0; i < count; i++)
    {
      var obj = Instantiate(_prefab);
      obj.gameObject.SetActive(false);
      ReturnToPool(obj);
    }
  }

  public T NextPoolObject()
  {
    return _objectPool.Dequeue();
  }

  public void ReturnToPool(T obj)
  {
    _objectPool.Enqueue(obj);
  }
#endregion

  protected void SetPoolParent(GameObject parent)
  {
    foreach (T obj in _objectPool)
    {
      obj.transform.SetParent(parent.transform);
    }
  }
}