using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public enum MovementType
    {
        Moving,
        Lepring
    }

    public MovementType _type = MovementType.Moving;
    public MovementPath _myPath;
    public float speed = 1;
    public float _maxDistance = .1f;

    public IEnumerator<Transform> PointInPath;

    private void Start()
    {
        if (_myPath == null)
        {
            Debug.Log("Примени путь");
            return;
        }

        PointInPath = _myPath.GetNextPathPoint();
        PointInPath.MoveNext();

        if (PointInPath.Current == null)
        {
            Debug.Log("Нужны точки");
            return;
        }

        transform.position = PointInPath.Current.position;
    }

    private void Update()
    {
        if (PointInPath == null || PointInPath.Current == null)
        {
            return;
        }
        if ( _type == MovementType.Moving )
        {
            transform.position = Vector3.MoveTowards(transform.position, PointInPath.Current.position, Time.deltaTime * speed);
        }
        else if (_type == MovementType.Lepring)
        {
            transform.position = Vector3.Lerp(transform.position, PointInPath.Current.position, Time.deltaTime * speed);
        }

        var _distanceSquare = (transform.position - PointInPath.Current.position).sqrMagnitude;
        if (_distanceSquare < _maxDistance * _maxDistance)
        {
            PointInPath.MoveNext();
        }
    }
}
