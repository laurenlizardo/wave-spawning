using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Wave<T> : ScriptableObject where T : Component
{
  public int NumberOfWaveElements;
  public List<T> WaveElements = new List<T>();

  public WaveFormation WaveFormation;
}