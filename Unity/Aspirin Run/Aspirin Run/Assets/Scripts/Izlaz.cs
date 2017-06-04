using UnityEngine;
using System.Collections;

public class Izlaz : MonoBehaviour {

	void Update() {
		if (Input.GetKey("escape"))
			Application.Quit();

	}
}
