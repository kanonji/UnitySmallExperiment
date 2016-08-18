using UnityEngine;
using System.Collections;

namespace Kanonji.SmallExperiment.SingletonAsGlobal {

	public class Register : MonoBehaviour {

		[SerializeField] protected GameObject prefab;

		void Awake() {
			Singleton singleton = Singleton.GetInstance();
			singleton.Add(prefab);
		}
	}
}
