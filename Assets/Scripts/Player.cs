using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
    public float shotCooldown;
    public Transform shotSpawn;
    public GameObject shot;

    bool canFire;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        // Link to Rigidbody Component
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        // Get Input
        Vector2 moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // Move Ship
        rb.AddForce(moveVector * speed);

        // Fire if needed
        if (Input.GetButtonDown("Jump")) {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
	}
}
