using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bilboard : MonoBehaviour {


	public Transform target;

	void Start () {
		target = GameObject.Find("Target_Billboard").transform;

		Vector3 targetPostition  = new Vector3(target.position.x, this.transform.position.y, target.position.z);
		transform.LookAt(targetPostition);
		transform.Rotate(0, 180, 0);
	}


}
