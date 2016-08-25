using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

	[SerializeField] protected GameObject gameObject;

	public void Invoke() {
		Instantiate(gameObject);
	}
}
