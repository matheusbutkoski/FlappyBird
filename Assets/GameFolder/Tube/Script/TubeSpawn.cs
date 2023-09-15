using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeSpawn : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1;
    public float min;
    public float max;

    private void OnEnable(){
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable(){
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn(){
        GameObject tubes = Instantiate(prefab, transform.position, Quaternion.identity);
        tubes.transform.position += Vector3.up * Random.Range(min, max);

    }
}
