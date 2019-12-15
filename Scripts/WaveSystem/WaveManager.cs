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

  [SerializeField] private int _numberOfWaves => Waves.Count;

  private protected int _currentWaveIndex;
  public int CurrentWaveIndex => _currentWaveIndex;

  [SerializeField] protected List<T> Waves = new List<T>();

  public int NumberOfEnemies => TestEnemy.EnemyCount;

  public abstract IEnumerator SpawnWave();
}
