using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private PlayerController playerControllerScript;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);

    float startDelay = 2;
    float repeatRate = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstaclePrefab", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }


    void SpawnObstaclePrefab()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);

        }
    }



}
