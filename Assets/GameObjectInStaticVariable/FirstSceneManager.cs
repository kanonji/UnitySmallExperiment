using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Kanonji.SmallExperiment.GameObjectInStaticVariable {

	public class FirstSceneManager : MonoBehaviour {

		public GameObject go;

		private void Start() {
			StaticContainer.go = go;
			StaticContainer.str = "this is string.";
			StaticContainer.barClass = new BarClass();
			StaticContainer.bazStruct = BazStruct.Init();

			Debug.Log("FirstSceneManager: StaticContainer.go: " + StaticContainer.go);
			Debug.Log("FirstSceneManager: StaticContainer.str: " + StaticContainer.str);
			Debug.Log("FirstSceneManager: StaticContainer.barClass: " + StaticContainer.barClass.foo + StaticContainer.barClass.GetBar());
			Debug.Log("FirstSceneManager: StaticContainer.bazStruct: " + StaticContainer.bazStruct.foo + StaticContainer.bazStruct.GetBar());
		}

		public void Transit() {
			SceneManager.LoadScene("GameObjectInStaticVariable/SecondScene");
		}
	}
}
