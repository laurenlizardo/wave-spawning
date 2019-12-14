using UnityEngine;
using System.Collections;

public class EnemyWaveController : WaveController<EnemyWave>
{
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
