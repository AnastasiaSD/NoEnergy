using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int pointsWorth = 1;
	public int keyID = 0;

	void Start()
	{
		if (GlobalValue.KeyID[keyID])
        {
			Destroy(gameObject);
		}
	}

		private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string playerTag = otherCollider.gameObject.tag;

		// is the other object a player?
		if (playerTag == "Player" || playerTag == "Player2")
		{
            GlobalValue.AddScore(pointsWorth);
			GlobalValue.KeyID[keyID] = true;

			// then destroy this object
			Destroy(gameObject);
		}
	}
}
