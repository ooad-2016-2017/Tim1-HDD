using UnityEngine;
using System.Collections;

public class CreateRandomMonster : MonoBehaviour {

	public GameObject enemyPrefab;
	public float numEnemies;
	public float xMin =20f;
	public float xMax=85f;
	public float yMin=1.5f;
	public float yMax=-2.5f;

	void Start(){
		GameObject newParent = GameObject.Find ("1 - Bacground Elements");

		for (int i = 0; i < numEnemies; i++) {
			Vector3 newPos = new Vector3 (Random.Range (xMin, xMax), Random.Range (yMin, yMax), 0);
			GameObject octo = Instantiate (enemyPrefab, newPos, Quaternion.identity) as GameObject;
			octo.transform.parent = newParent.transform;
		}
	}
}
