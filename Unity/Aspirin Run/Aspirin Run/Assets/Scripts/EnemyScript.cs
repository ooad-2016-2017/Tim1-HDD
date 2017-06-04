using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public int damage = 1;
	private bool hasSpawn;
	private MoveScript moveScript;
	private WeaponScript[] weapons;
		void Awake()
	{
		weapons = GetComponentsInChildren<WeaponScript>();
		moveScript = GetComponent<MoveScript>();
	}
	void Start () {
		hasSpawn = false;
		this.gameObject.GetComponent<Collider2D>().enabled=false;
		moveScript.enabled = false;
		foreach (WeaponScript weapon in weapons)
		{
			weapon.enabled = false;
		}
	}

	void Update()
	{
		if (hasSpawn == false) {
			if (this.gameObject.GetComponent<Renderer>().IsVisibleFrom(Camera.main))
			{
				Spawn();
			}
		} else {
			foreach (WeaponScript weapon in weapons)
			{
				if (weapon != null && weapon.enabled && weapon.CanAttack)
				{
					weapon.Attack(true);
				}
			}
			if (this.gameObject.GetComponent<Renderer>().IsVisibleFrom(Camera.main) == false)
			{
				Destroy(gameObject);
			}
		}
	}

	private void Spawn()
	{
		hasSpawn = true;

		this.gameObject.GetComponent<Collider2D>().enabled=true;	// -- Moving
		moveScript.enabled = true;
		foreach (WeaponScript weapon in weapons)
		{
			weapon.enabled = true;
		}
	}
}