using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {

	private float minimum = 1.0f;
	private float magSpeed = 10.0f;
	private float magnification = 0.07f; //元の大きさの7%が変化の最大量 ±７％の間で変化


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localScale = new Vector3 (
			this.minimum + Mathf.Sin (Time.time * this.magSpeed) * this.magnification,
			this.transform.localScale.y, 
			this.minimum + Mathf.Sin (Time.time * this.magSpeed) * this.magnification
			// ↑初期のサイズ　　　　　　変化するスピード　　　　　　　　　　　　　　変化の割合
		);
	}
}
