using UnityEngine;
using System.Collections;

public class ColumnPool : MonoBehaviour
{
    public GameObject columnPrefab;                                 
    public int columnPoolSize = 5;                                  
    public float spawnRate = 3f;                                    
    public float columnMin = -1f;                                   
    public float columnMax = 3.5f;                                  

    private GameObject[] columns;                                   
    private int currentColumn = 0;                                  

    private Vector2 objectPoolPosition = new Vector2(-15f, -42f);     
    private float spawnXPosition = 10f;

    private float timeSinceLastSpawned;


    void Start()
    {
        timeSinceLastSpawned = 0f;
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }


    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameController.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;

            float spawnYPosition = Random.Range(columnMin, columnMax);


            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            currentColumn++;

            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}