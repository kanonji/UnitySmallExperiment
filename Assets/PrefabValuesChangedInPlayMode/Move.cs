using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	[SerializeField] protected Vector3 direction;
	[SerializeField] protected float speed;
	
	void Update () {
		Vector3 moveVolume = direction * Time.deltaTime * speed;
		transform.Translate(moveVolume);
	}
}
