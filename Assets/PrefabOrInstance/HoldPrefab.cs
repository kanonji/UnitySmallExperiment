using UnityEngine;
using System.Collections;

namespace Kanonji.SmallExperiment.PrefabOrInstance {

	public class HoldPrefab : MonoBehaviour {

		[SerializeField] protected GameObject prefab;

		void Awake() {
			Debug.Log("this.gameObject.name: " + gameObject.name);
			Debug.Log("this.gameObject.activeInHierarchy: " + gameObject.activeInHierarchy);
			Debug.Log("this.gameObject.GetInstanceID(): " + gameObject.GetInstanceID());
			Debug.Log("this.gameObject.transform.position: " + gameObject.transform.position);
			Debug.Log("this.prefab.name: " + prefab.name);
			Debug.Log("this.prefab.activeInHierarchy: " + prefab.activeInHierarchy);
			Debug.Log("this.prefab.GetInstanceID(): " + prefab.GetInstanceID());
			Debug.Log("this.prefab.transform.position: " + prefab.transform.position);
			Debug.Log("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
		}
	}
}
