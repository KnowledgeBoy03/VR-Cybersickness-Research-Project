using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    private bool _timerActive = false;
    private float _currentTime;
    public TextMeshProUGUI currentTimeText;
    
    void Start()
    {
        _currentTime = 0;
    }
    
    void Update()
    {
        if (_timerActive == true)
        {
            _currentTime += Time.deltaTime;
        }

        TimeSpan time = TimeSpan.FromSeconds(_currentTime);

        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
    }

    public void StartTimer()
    {
        _timerActive = true;
    }

    public void StopTimer()
    {
        _timerActive = false;
    }
}
