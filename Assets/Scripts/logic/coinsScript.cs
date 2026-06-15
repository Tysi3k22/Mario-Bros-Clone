using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class coinsScript : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    private gameLogicScript logic;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("gameLogic").GetComponent<gameLogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addCoin();
        Destroy(coin);
    }
}
