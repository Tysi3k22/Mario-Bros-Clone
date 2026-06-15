using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class specialBlocksScript : MonoBehaviour
{
    private gameLogicScript logic;
    [SerializeField] private GameObject specialBlock;
    public Transform bottomCheck;
    public LayerMask bottomLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("gameLogic").GetComponent<gameLogicScript>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.transform.position.y < transform.position.y)
            {
                logic.specialBlockReward(specialBlock);
            }
        }
    }
}
