using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

    public Transform[] spawnLocations;
    public GameObject[] spawnPrefabs;
    public GameObject[] spawnClones;

    void Start() {
        Spawns();
    }
    void Spawns () {
        int spawnPointIndexL = Random.Range(0, spawnLocations.Length);
        int spawnPointIndexP = Random.Range(0, spawnPrefabs.Length);
        int spawnPointIndexC = Random.Range(0, spawnClones.Length);

        spawnClones[spawnPointIndexC] = Instantiate(spawnPrefabs[spawnPointIndexP], spawnLocations[spawnPointIndexL].transform.position, Quaternion.Euler(0f, 0f, 0f)) as GameObject;
    }
	
}
