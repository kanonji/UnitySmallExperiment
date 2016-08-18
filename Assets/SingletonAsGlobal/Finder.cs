using UnityEngine;
using System.Collections;

namespace Kanonji.SmallExperiment.SingletonAsGlobal {

	public class Finder : MonoBehaviour {

		[SerializeField] protected string prefabName;
		[SerializeField] protected GameObject prefab;
		protected GameObject Prefab {
			get {
				Singleton singleton = Singleton.GetInstance();
				prefab = singleton.Get(prefabName);
				return prefab;
			}
		}

		void Start() {
			Debug.Log(Prefab);
		}
	}
}
