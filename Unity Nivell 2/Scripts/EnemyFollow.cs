using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;


public class Perseguir : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;

    public Transform Enemy;


    public float llindar;

    

    private void OnTriggerEnter(Collider other)
    {
        enemy.speed = 3;
    }

    private void OnTriggerExit(Collider other)
    {
        enemy.speed = 30;
    }

    // Update is called once per frame
    void Update()
    {


       
        if (Math.Abs(Enemy.position.x - Player.position.x) >= llindar ||
            Math.Abs(Enemy.position.y - Player.position.y) >= llindar ||
            Math.Abs(Enemy.position.z - Player.position.z) >= llindar)
        {
            enemy.speed = 30;

        }
        else
            enemy.speed = 3;


        enemy.SetDestination(Player.position);

    }
}
