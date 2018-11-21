using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nosMovemosSanta : MonoBehaviour {
    Rigidbody2D Santa;
    public float velocidadMaxima = 5;

	// Use this for initialization
	void Start () {
        
        Santa = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

        float h = Input.GetAxis("Horizontal");
        Santa.velocity = new Vector2(h, 0) * velocidadMaxima;
	}
}
