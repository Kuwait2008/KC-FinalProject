using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleGenerator : MonoBehaviour
{
    public GameObject pipePrefab;
    public int generationRate = 100;
    private int timer;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        if (timer >= generationRate) ;
        {
            timer = 0;
            GameObject newObstacle = Instantiate(pipePrefab, new Vector2(pipePrefab.transform.position.x, pipePrefab.transform.position.y + Random.Range(-2f, 2f)), pipePrefab.transform.rotation);
            Destroy(newObstacle, 10f);
        }
    }
}
