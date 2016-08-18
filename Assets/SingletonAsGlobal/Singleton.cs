using UnityEngine;
using System.Collections.Generic;

namespace Kanonji.SmallExperiment.SingletonAsGlobal {

	public class Singleton {
		protected Dictionary<string, GameObject> dictionary = new Dictionary<string, GameObject>();
		private static Singleton instance = new Singleton();

		public static Singleton GetInstance() {
			return instance;
		}

		private Singleton() {
		}

		public void Add(GameObject go) {
			dictionary.Add(go.name, go);
		}

		public GameObject Get(string name) {
			//List<string> keys = new List<string>();
			//foreach(var key in dictionary.Keys) {
			//	keys.Add(key);
			//}
			//Debug.Log(string.Join(", ", keys.ToArray()));
			return dictionary[name];
		}
	}
}
