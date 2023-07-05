using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bulletPrefab = default;
    public float spawnerRateMin = 0.5f;
    public float spawnerRateMax = 3f;

    public Transform bulletPool = default;

    private Transform target = default;
    private float spawnRate = default;
    private float timeAfterSpawn = default;

    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnerRateMin, spawnerRateMax);
        target = FindAnyObjectByType<Player>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (spawnRate <= timeAfterSpawn)
        {
            timeAfterSpawn = 0;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation, bulletPool);
            bullet.transform.LookAt(target);
            transform.LookAt(target);

            spawnRate = Random.Range(spawnerRateMin, spawnerRateMax);
        }
        
    }
}
