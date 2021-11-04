using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitSpawnScript : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawners;
    [SerializeField]
    private GameObject healthKitPrefab;
    [SerializeField]
    private int spawnInterval;

    private Dictionary<Transform, GameObject> transformAndHealthKits = new Dictionary<Transform, GameObject>();

    private int randomIndex;

    private GameObject spawnedKit;
    
    public void Start()
     {

        StartCoroutine(SpawnCoroutine());
        /*int spawnerCount = spawners.Length;
        randomIndex = Random.Range(0, spawnerCount);
        Transform randomPoint = spawners[randomIndex];
        GameObject healthKit = Instantiate(healthKitPrefab, randomPoint);
        healthKit.SetActive(false);*/
       
    }

    public void Update()
    {
        
    }

    IEnumerator SpawnCoroutine()
    {
        
        if (HealthKit.kitJustPickedUp)
        {
            HealthKit.kitJustPickedUp = false;
            
        }else if ( GameObject.FindWithTag("HealthKit") == null)
            { SpawnKit(); 
            }


        yield return new WaitForSeconds(spawnInterval);
        StartCoroutine(SpawnCoroutine());
    }

    public void SpawnKit() {


        int spawnerCount = spawners.Length;


        randomIndex = Random.Range(0, spawnerCount);

        Transform randomPoint = spawners[randomIndex];

        Instantiate(healthKitPrefab, randomPoint);

    }

    
}