using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour {

	private GameObject PointText;
	private int point = 0;

	// Use this for initialization
	void Start () {
		this.PointText = GameObject.Find ("PointText");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "LargeStarTag") {
			PointSum (10);
		} else if (other.gameObject.tag == "SmallStarTag") {
			PointSum (20);
		} else if (other.gameObject.tag == "LargeCloudTag") {
			PointSum (10);
		} else if (other.gameObject.tag == "SmallCloudTag") {
			PointSum (20);
		}
		// else if (other.gameObject.tag == ""){}
	}

	public void PointSum (int p) {
		point += p;
		string points = point.ToString ();
		this.PointText.GetComponent<Text> ().text = points + "Pt";
	}
}
