using UnityEngine;
using System;
using System.Collections.Generic;

public class WaveController : MonoBehaviour
{
#region Singleton Pattern
  private static WaveController _instance;
  public static WaveController Instance => _instance;

  private void Awake()
  {
    if (_instance == null) _instance = this;
    else Destroy(gameObject);
  }
#endregion

  [SerializeField] private int _numberOfWaves;
  public int NumberOfWaves => _numberOfWaves;

  private int _currentWaveIndex;
  public int CurrentWaveIndex => _currentWaveIndex;

  public List<EnemyWave> EnemyWaves = new List<EnemyWave>();

  public int NumberOfEnemies => Enemy.EnemyCount;

  private void Update()
  {
    if (Input.GetKey(KeyCode.Space)) Debug.Log(NumberOfEnemies);
  }
}
