using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	private float visiblePosZ = -6.5f;
	private GameObject gameoverText;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		this.gameoverText = GameObject.Find ("GameOverText");
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < this.visiblePosZ) {
			this.gameoverText.GetComponent<Text> ().text = "Game Over";

			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				this.gameoverText.GetComponent<Text> ().text = "";
				rb.velocity = Vector3.zero;
				this.transform.position = new Vector3(2, 3, 4);
			}
		}
	}
}
