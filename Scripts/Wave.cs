using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create New Wave", fileName = "New Wave")]
public class Wave : ScriptableObject
{
  public int NumberOfEnemies;
  public List<Enemy> WaveEnemies = new List<Enemy>();

  public WaveFormation Formation;
}