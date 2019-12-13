using System.Collections.Generic;
using UnityEngine;

public abstract class Wave<T> : ScriptableObject where T : Component
{
  public WaveFormation WaveFormation;
  public List<Transform> Spawnpoints => WaveFormation.GetSpawnpoints();
  public int NumberOfWaveElements => WaveFormation.GetSpawnpoints().Count;
  public List<T> WaveElements = new List<T>();
}