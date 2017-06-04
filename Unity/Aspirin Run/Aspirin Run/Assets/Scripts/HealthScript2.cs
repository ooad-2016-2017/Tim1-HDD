using UnityEngine;
using System.Collections;

public class HealthScript2 : MonoBehaviour {


	public bool isEnemy =true;
	public int hp = 1;
	public void Damage(int damageCount)
	{
		hp -= damageCount;

		if (hp <= 0)
		{
			SpecialEffectsHelper.Instance.Explosion(transform.position);
			Destroy(gameObject);

		}
	}
	void OnTriggerEnter2D (Collider2D collider) {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript> ();
		if (shot !=null)
		{
			if(shot.isEnemyShot != isEnemy)
			{
				hp-=shot.damage;
				Destroy (shot.gameObject);

				if (hp <= 0) {
					SpecialEffectsHelper.Instance.Explosion(transform.position);
					Destroy (gameObject);

				}
			}
		}
	}
}


