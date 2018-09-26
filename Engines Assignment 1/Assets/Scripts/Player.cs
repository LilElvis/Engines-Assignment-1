using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public bool hasWon;
    public Vector3 startPosition;
    public Quaternion startRotation;

	// Use this for initialization
	void Start ()
    {
        startPosition.Set(0.0f, 1.0f, 0.0f);
        startRotation.Set(0.0f, 0.0f, 0.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Reset()
    {
        hasWon = false;
        this.transform.SetPositionAndRotation(startPosition, startRotation);
    }
}
