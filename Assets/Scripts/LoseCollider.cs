using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
	public LevelManager levelManager;
	void OnTriggerEnter2D (Collider2D collider) {
		Debug.Log("Lose Collider Triggered");
		levelManager.LoadLevel("Lose");
	}
}
