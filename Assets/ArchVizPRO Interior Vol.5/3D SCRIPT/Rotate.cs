using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public float rotationsPerMinute;

	void Update () {
		transform.Rotate(Vector3.forward * rotationsPerMinute * Time.deltaTime);
	}
}
