using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour {

    private GameObject m_Player;
    void Start ()
    {
        m_Player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(m_Player.GetComponent<Player>().hasWon)
        {
            Debug.Log("YOU WIN");
        }
	}
}
