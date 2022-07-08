using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<Transform> spawnPoints = new List<Transform>();
    [SerializeField] GameObject SheepPrefab;
    [SerializeField] int amountSheeps;

    private void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        for (int i = 0; i < amountSheeps; i++)
        {
            int randomNumber = Random.Range(0, spawnPoints.Count);
            GameObject sheep = SpawnSheep(spawnPoints[randomNumber]);
            spawnPoints.RemoveAt(randomNumber);
        }
    }
    private GameObject SpawnSheep(Transform spawnPoint)
    {
        return Instantiate(SheepPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
