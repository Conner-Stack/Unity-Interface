using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertState : IEnemyState {
    public void OnTriggerEnter(Collider other)
    {
        throw new NotImplementedException();
    }

    public void ToAlertState()
    {
        throw new NotImplementedException();
    }

    public void ToChaseState()
    {
        throw new NotImplementedException();
    }

    public void ToPatrolState()
    {
        throw new NotImplementedException();
    }

    // Use this for initialization

    void IEnemyState.Update()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame

}
