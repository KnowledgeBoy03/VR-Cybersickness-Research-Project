using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Stopwatch stopwatch;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("SOMETHING CAME");
        stopwatch.StartTimer();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("SOMETHING LEFT");
        stopwatch.StopTimer();
    }
}
