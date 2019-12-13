using System.Collections.Generic;
using UnityEngine;

public class WaveFormation : MonoBehaviour
{
  public List<Transform> GetSpawnpoints()
  {
    List<Transform> list = new List<Transform>();

    for (int i = 0; i < transform.childCount; i++)
    {
      list.Add(transform.GetChild(i).transform);
    }

    return list;
  }
}
