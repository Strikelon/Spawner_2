using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Transform[] _wayPoints;

    private int _currentWayPointIndex;

    private void Start()
    {
        _currentWayPointIndex = 0;
    }

    private void Update()
    {
        if (transform.position == _wayPoints[_currentWayPointIndex].position)
        {
            _currentWayPointIndex = (_currentWayPointIndex + 1) % _wayPoints.Length;
        }

        transform.position = Vector2.MoveTowards(transform.position, _wayPoints[_currentWayPointIndex].position, _moveSpeed * Time.deltaTime);
    }
}
