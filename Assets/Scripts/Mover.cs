using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public Vector2 moveDir;
    Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(moveDir, ForceMode2D.Impulse);
	}
}
