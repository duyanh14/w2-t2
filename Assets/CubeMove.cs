using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] List<Transform> Positions = new List<Transform>();
    
    int PositionIndex = 0;
    float Speed = 5f;

    void Start()
    {
        transform.Translate(0,0,0);
    }

    void SetPositionIndex()
    {
        if (PositionIndex > Positions.Count - 1)
        {
            PositionIndex = 0;
            return;
        }
        PositionIndex++;
    }

    void Update()
    {
        if (Positions.Count == 0){
            return;
        }

        if (Positions[PositionIndex] == null) {
            Positions.RemoveAt(PositionIndex);
            SetPositionIndex();
        }

        if (Vector3.Distance(Positions[PositionIndex].position, transform.position) == 0)
        {
            SetPositionIndex();
        }

        transform.position = Vector3.MoveTowards(transform.position, Positions[PositionIndex].position, Speed * Time.deltaTime);
        transform.Rotate(10, Speed * Time.deltaTime, 10);
    }

    void OnDrawGizmos()
    {
        if (Positions[PositionIndex] == null)
        {
            return;
        }
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, Positions[PositionIndex].position);
    }

}
