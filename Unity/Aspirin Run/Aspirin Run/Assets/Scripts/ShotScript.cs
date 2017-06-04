using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

	public int damage = 1;
	public bool isEnemyShot = false;

	void Start () {
		Destroy (gameObject, 20);

	}
	

}
