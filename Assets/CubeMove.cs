using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    
    int PositionIndex = 0;
    float Speed = 5f;

    void Start()
    {
        transform.Translate(0,0,0);
    }

    void Update()
    {
        if (Positions.Length == 0){
            return;
        }
        if (Vector3.Distance(Positions[PositionIndex].position, transform.position) == 0)
        {
            PositionIndex++;
            if (PositionIndex > Positions.Length-1)
            {
                PositionIndex = 0;
            }
        } 

        transform.position = Vector3.MoveTowards(transform.position, Positions[PositionIndex].position, Speed * Time.deltaTime);
        transform.Rotate(10, Speed * Time.deltaTime, 10);
    }

    void OnDrawGizmos()
    {
       
    }

}
