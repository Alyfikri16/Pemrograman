using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {
	public float kecepatan;
	public string axis;
	public float BatasAtas;
	public float BatasBawah;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float gerak = Input.GetAxis (axis) * kecepatan * Time.deltaTime;
		float nextPos = transform.position.y+gerak;
		if (nextPos > BatasAtas){
			gerak = 0;
		}
		if (nextPos < BatasBawah){
			gerak = 0;
		}
		transform.Translate (gerak, 0, 0);
	}
}
