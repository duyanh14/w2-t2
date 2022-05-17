using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PointControl : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
      
    }

}

[CustomEditor(typeof(PointControl))]
public class PointControlEditor : Editor
{
    PointControl pt;

    void OnSceneGUI()
    {
        Event e = Event.current;
        switch (e.type)
        {
            case EventType.KeyDown:
                {
                    if (Event.current.keyCode == (KeyCode.A))
                    {
                        //Destroy(Selection.activeObject);
                        Destroy(pt.gameObject);
                    }
                    break;
                }
        }
    }

    void OnEnable()
    {
        pt = target as PointControl;
    }
}