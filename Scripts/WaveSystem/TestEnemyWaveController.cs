using UnityEngine;
using System.Collections;

public class TestEnemyWaveController : WaveController<TestEnemyWave>
{
  public int WaveIndex;

  private int _waveIndex
  {
    get 
    {
      if (WaveIndex > Waves.Count - 1) return 0;
      return WaveIndex;
    }
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      StartCoroutine(SpawnWave());
      Debug.Log(NumberOfEnemies);
    } 
  }

  public override IEnumerator SpawnWave()
  {
    for (int i = 0; i < Waves[_waveIndex].WaveElements.Count; i++)
    {
      GameObject obj = Waves[_waveIndex].WaveElements[i].NextPoolObject();
      obj.transform.position = Waves[_waveIndex].Spawnpoints[i].transform.position;
      obj.transform.rotation = Quaternion.identity;
      obj.SetActive(true);

      yield return new WaitForSeconds(Waves[_waveIndex].SpawnDelay);
    }
  }
}