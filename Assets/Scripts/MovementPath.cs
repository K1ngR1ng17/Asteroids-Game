using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPath : MonoBehaviour
{
    public enum PathTypes
    {
        linear,
        loop
    }
    public PathTypes _pathType;
    public int _movementDirection = 1; //направление движения : вперед либо назад
    public int _movingTo = 0; // к какой точке будем двигаться
    public Transform[] PathElements;

    public void OnDrawGizmos()
    {
        if (PathElements == null || PathElements.Length < 2)
        {
            return;
        }

        for (var i = 1; i < PathElements.Length; i++)
        {
            Gizmos.DrawLine(PathElements[i - 1].position, PathElements[i].position);
        }

        if (_pathType == PathTypes.loop)
        {
            Gizmos.DrawLine(PathElements[0].position, PathElements[PathElements.Length - 1].position);
        }
    }

    public IEnumerator<Transform> GetNextPathPoint()
    {
        if (PathElements == null || PathElements.Length < 1)
        {
            yield break;
        }
        while(true)
        {
            yield return PathElements[_movingTo];

            if (PathElements.Length == 1)           
                continue;

            if (_pathType == PathTypes.linear)
            {
                if (_movingTo <= 0)
                {
                    _movementDirection = 1;
                }
                else if (_movingTo <= PathElements.Length - 1)
                {
                    _movementDirection = -1;
                }
            }
            _movingTo += _movementDirection;

            if (_pathType == PathTypes.loop)
            {
                if (_movingTo >= PathElements.Length)
                {
                    _movingTo = 0;
                }

                if (_movingTo < 0)
                {
                    _movingTo = PathElements.Length - 1;
                }
            }
        }     
    }

}
