using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class WaveController<T> : MonoBehaviour where T : class
{
#region Singleton Pattern
  private static WaveController<T> _instance;
  public static WaveController<T> Instance => _instance;

  private void Awake()
  {
    if (_instance == null) _instance = this;
    else Destroy(gameObject);
  }
#endregion

  [SerializeField] private int _numberOfWaves => Waves.Count;

  private protected int _currentWaveIndex;
  public int CurrentWaveIndex => _currentWaveIndex;

  protected List<T> Waves = new List<T>();

  public int NumberOfEnemies => Enemy.EnemyCount;

  public abstract IEnumerator SpawnWave();
}
