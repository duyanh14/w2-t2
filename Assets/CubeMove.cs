using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    int positionIndex = 0;
    float speed = 5f;

    void Start()
    {
        transform.Translate(0,0,0);

        this.positions.Add(new Vector3(-10, 0f, 0f));
        this.positions.Add(new Vector3(-10, 0f, 10f));
        this.positions.Add(new Vector3(0f, 0f, 10f));
        this.positions.Add(new Vector3(0f, 0f, 0f));
    }

    void Update()
    {
        if (Vector3.Distance(positions[positionIndex], transform.position) == 0)
        {
            positionIndex++;
            if (positionIndex > positions.Count-1)
            {
                positionIndex = 0;
            }
        } 

        transform.position = Vector3.MoveTowards(transform.position, positions[positionIndex], speed * Time.deltaTime);
        transform.Rotate(10, speed * Time.deltaTime, 10);
    }

}
