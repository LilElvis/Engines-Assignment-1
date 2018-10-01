//The Bullet class's logic for taking on a shared mesh mirrors the Unity documentation found here: https://docs.unity3d.com/2017.3/Documentation/ScriptReference/MeshFilter-sharedMesh.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float scaleFactor = 2.0f;

    void Start ()
    {
        Mesh mesh = GetComponent<MeshFilter>().sharedMesh;
        Vector3[] vertices = mesh.vertices;
        int p = 0;
        while(p < vertices.Length)
        {
            vertices[p] *= scaleFactor;
            p++;
        }
        mesh.vertices = vertices;
        mesh.RecalculateNormals();
	}
	
	void Update ()
    {
		
	}
}
