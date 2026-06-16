using UnityEngine;

public class enemiesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        createEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void createEnemy()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("enemySpawner");

        foreach (GameObject obj in objects) { 
            Instantiate(enemy, obj.transform.position, obj.transform.rotation);
        }
    }
}
