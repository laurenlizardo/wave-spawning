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

  [Serializable]
  public class WaveFormation
  {
    public enum WaveState
    {
      Loading,
      Active,
      Dead
    }
    
    public GameObject WaveFormationObject; // The gameobject requires children

    // Decide on list or queue approach
    [SerializeField] public List<Transform> SpawnpointList = new List<Transform>();
    [SerializeField] public Queue<Transform> SpawnpointQueue = new Queue<Transform>();

    public void GetSpawnpoints()
    {
      for (int i = 0; i < WaveFormationObject.transform.childCount; i++)
      {
        SpawnpointList.Add(WaveFormationObject.transform.GetChild(i).transform);
        SpawnpointQueue.Enqueue(WaveFormationObject.transform.GetChild(i).transform);
      }
    }
  }

  public List<WaveFormation> WaveFormations = new List<WaveFormation>();

  private void Start()
  {
    foreach (WaveFormation waveFormation in WaveFormations)
    {
      waveFormation.GetSpawnpoints();
    }
  }
}
