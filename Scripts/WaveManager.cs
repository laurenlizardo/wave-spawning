using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class WaveManager<T> : MonoBehaviour where T : class
{
#region Singleton Pattern
  private static WaveManager<T> _instance;
  public static WaveManager<T> Instance => _instance;

  private void Awake()
  {
    if (_instance == null) _instance = this;
    else Destroy(gameObject);
  }
#endregion

  public int CurrentWaveIndex;
  private protected int _currentWaveIndex => (CurrentWaveIndex > Waves.Count - 1) ? 0 : CurrentWaveIndex;

  [SerializeField] protected List<T> Waves = new List<T>();

  public abstract void SpawnWaveElements();
  public abstract IEnumerator SpawnWaveElementsInOrder();

  public float TimeDelayBeforeWave;
}