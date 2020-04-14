using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObstacleSpawn : MonoBehaviour
{
    public GameObject[] colorObstacles;
    public float platformSpawnTimer = 2f;
    private float currentPlatformSpawnTimer;
    void Start()
    {
        currentPlatformSpawnTimer = platformSpawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnColorObstacleBar();
    }

    void SpawnColorObstacleBar() {
        currentPlatformSpawnTimer += Time.deltaTime;

        if (currentPlatformSpawnTimer >= platformSpawnTimer)
        {


            for (int i = 0; i < colorObstacles.Length; i++)
            {
                GameObject temp = colorObstacles[i];
                int r = Random.Range(i, colorObstacles.Length);
                colorObstacles[i] = colorObstacles[r];
                colorObstacles[r] = temp;
            }

            GameObject obstacleBox1 = null, obstacleBox2 = null, obstacleBox3 = null, obstacleBox4 = null, obstacleBox5 = null, obstacleBox6 = null;
            Vector3 parentPos = transform.position;
            obstacleBox1 = Instantiate(colorObstacles[0], new Vector3(-2.5f, parentPos.y, parentPos.z), Quaternion.identity);
            obstacleBox2 = Instantiate(colorObstacles[1], new Vector3(-1.5f, parentPos.y, parentPos.z), Quaternion.identity);
            obstacleBox3 = Instantiate(colorObstacles[2], new Vector3(-0.5f, parentPos.y, parentPos.z), Quaternion.identity);
            obstacleBox4 = Instantiate(colorObstacles[3], new Vector3(0.5f, parentPos.y, parentPos.z), Quaternion.identity);
            obstacleBox5 = Instantiate(colorObstacles[4], new Vector3(1.5f, parentPos.y, parentPos.z), Quaternion.identity);
            obstacleBox6 = Instantiate(colorObstacles[5], new Vector3(2.5f, parentPos.y, parentPos.z), Quaternion.identity);

            currentPlatformSpawnTimer = 0f;
        }

    }

    
        
}


