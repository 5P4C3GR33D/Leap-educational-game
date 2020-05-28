using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 spawnLocation;

    public void SpawnSphere()
    {
        Instantiate(objectToSpawn, spawnLocation, Quaternion.identity);
    }
}
