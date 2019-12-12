using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveFormation : MonoBehaviour
{
  public enum WaveState
  {
    Loading,
    Active,
    Dead
  }

  // Decide on list or queue approach
  [SerializeField] public List<Transform> SpawnpointList = new List<Transform>();
  [SerializeField] public Queue<Transform> SpawnpointQueue = new Queue<Transform>();

  public void GetSpawnpoints()
  {
    for (int i = 0; i < transform.childCount; i++)
    {
      SpawnpointList.Add(transform.GetChild(i).transform);
      SpawnpointQueue.Enqueue(transform.GetChild(i).transform);
    }
  }

  private void Start()
  {
    GetSpawnpoints();
  }
}
