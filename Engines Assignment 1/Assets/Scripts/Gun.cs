//This Gun class was made following a Unity Tutorial found here: https://unity3d.com/learn/tutorials/temas/multiplayer-networking/shooting-single-player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform bulletSpawn;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        if(Input.GetButton("Space"))
        {
            Fire();
        }
    }

    void Fire()
    {
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 12;

        Destroy(bullet, 2.0f);
    }
}
