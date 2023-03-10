using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    public Transform SnakeHead;
    public float SphereDiametr;

    
    private List<Transform> tailsSpheres = new List<Transform>();
    private List<Vector3> positions = new List<Vector3>();
    private List<Vector3> normals = new List<Vector3>();



    void Start()
    {
        positions.Add(SnakeHead.position);
        AddSphere();
        AddSphere();
    }

    // Update is called once per frame
    void Update()
    {
        float distance =((Vector3)SnakeHead.position- positions[0]).magnitude;
        if (distance > SphereDiametr)
        {
            positions.Insert(0, SnakeHead.position);
            positions.RemoveAt(positions.Count-1);

            distance -= SphereDiametr;
        }
        for (int i = 0; i < tailsSpheres.Count; i++)
        {
            tailsSpheres[i].position = Vector3.Lerp(positions[i+1], positions[i], distance/SphereDiametr);
        }
    }

    public void AddSphere() 
    {
        Transform _sphera = Instantiate(SnakeHead, positions[positions.Count-1],Quaternion.identity, transform);
        tailsSpheres.Add(_sphera);
        positions.Add(_sphera.position);
    }
}
