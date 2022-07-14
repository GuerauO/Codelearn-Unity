using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;


public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public Animator animator;
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

        enemy.SetDestination(Player.position);


        if (Math.Abs(Enemy.position.x - Player.position.x) >= llindar ||
            Math.Abs(Enemy.position.y - Player.position.y) >= llindar ||
            Math.Abs(Enemy.position.z - Player.position.z) >= llindar)
        {

            enemy.speed = 30;
            animator.SetBool("Lluny", true);


        }
        else
        {
            enemy.speed = 3;
            animator.SetBool("Lluny", false);
        }

        enemy.SetDestination(Player.position);

    }
}
