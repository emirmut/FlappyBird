using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipes;
    public Bird bird;
    public float spawnFrequency;
    public float height;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnPipes(spawnFrequency));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnPipes(float spawnFrequency) {
        while (!bird.isDead) {
            Instantiate(pipes, new Vector3(1.5f, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnFrequency);
        }
    }
}
