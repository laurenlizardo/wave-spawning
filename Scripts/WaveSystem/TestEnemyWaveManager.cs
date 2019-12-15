using UnityEngine;
using System.Collections;

public class TestEnemyWaveManager : WaveManager<TestEnemyWave>
{
  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      StartCoroutine(SpawnWave());
    } 
  }

  public override IEnumerator SpawnWave()
  {
    for (int i = 0; i < Waves[_currentWaveIndex].WaveElements.Count; i++)
    {
      GameObject obj = Waves[_currentWaveIndex].WaveElements[i].NextPoolObject();
      obj.transform.position = Waves[_currentWaveIndex].Spawnpoints[i].transform.position;
      obj.transform.rotation = Quaternion.identity;
      obj.SetActive(true);

      yield return new WaitForSeconds(Waves[_currentWaveIndex].SpawnDelay);
    }
  }
}