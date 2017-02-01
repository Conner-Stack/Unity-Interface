using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AlertState : IEnemyState {
    private readonly StatePatternEnemy enemy;
    private float searchTimer;

    public AlertState(StatePatternEnemy statePatternEnemy)
    {
        enemy = statePatternEnemy;
    }
    public void OnTriggerEnter(Collider other)
    {
        
    }

    public void ToAlertState()
    {
        Debug.Log("Can't transition to same state");
    }

    public void ToChaseState()
    {
        enemy.currentState = enemy.chaseState;
        searchTimer = 0f;
    }

    public void ToPatrolState()
    {
       
    }

    public void UpdateState()
    {
        Look();
        Search();
    }

    private void Look()
    {
        RaycastHit hit;
        if (Physics.Raycast(
            EnemyAttack.eyes.transform.position,
            enemy.eyes.transform.forward, out hit,
            enemy.sightRange) && hit.collider.CompareTag("Player"));
        enemy.chaseTarget _ = hit.transform;
        ToChaseState();
    }
    private void Search()
    {
        enemy.meshRendererFlag.material.color = Color.yellow;
        enemy.navMeshAgent.Stop();
        enemy.transform.Rotate(0, enemy.searchingTurnSpeed * Time.deltaTime, 0);
        searchTimer += Time.deltaTime;
        if (searchTimer >= enemy.searchingDuration)
            ToPatrolState();
    }
}
