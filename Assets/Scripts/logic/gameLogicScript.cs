using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameLogicScript : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    private HashSet<GameObject> spawnedObjects = new HashSet<GameObject>();
    [SerializeField] private Text text;

    private int coinCounter;

    public void specialBlockReward(GameObject @object)
    {
        if (!spawnedObjects.Contains(@object))
        {
            spawnedObjects.Add(@object);
            Instantiate(coin, new Vector3(@object.transform.position.x - 0.75f, @object.transform.position.y + 1), @object.transform.rotation);
        }
    }

    public void addCoin()
    {
        coinCounter++;
        text.text = "coins: " + coinCounter;
    }
}
