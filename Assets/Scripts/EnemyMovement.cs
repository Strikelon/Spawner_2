using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Transform _target;

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        if (transform.position != _target.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.position, _moveSpeed * Time.deltaTime);
        }
    }
}
