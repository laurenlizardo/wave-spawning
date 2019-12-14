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

  [SerializeField] private int _numberOfWaves => EnemyWaves.Count;

  private int _currentWaveIndex;
  public int CurrentWaveIndex => _currentWaveIndex;

  public List<EnemyWave> EnemyWaves = new List<EnemyWave>();

  public int NumberOfEnemies => Enemy.EnemyCount;

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      SpawnWave(EnemyWaves[_currentWaveIndex]);
      Debug.Log(NumberOfEnemies);
    } 
  }

  private void SpawnWave(EnemyWave wave)
  {
    for (int i = 0; i < wave.WaveElements.Count; i++)
    {
      //Instantiate(wave.WaveElements[i], wave.Spawnpoints[i].position, Quaternion.identity); // Works as long as the enemy count doesn't exceed spawnpoints
      
      // Access the pool that wave.WaveElements[i] belongs to and dequeue() from there
    }
  }
}
