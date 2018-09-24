using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kanonji.SmallExperiment.GameObjectInStaticVariable {

	public class SecondSceneManager : MonoBehaviour {

		// Use this for initialization
		void Start() {
			Debug.Log("SecondSceneManager: StaticContainer.go: " + StaticContainer.go);
			Debug.Log("SecondSceneManager: StaticContainer.str: " + StaticContainer.str);
			Debug.Log("SecondSceneManager: StaticContainer.barClass: " + StaticContainer.barClass.foo + StaticContainer.barClass.GetBar());
			Debug.Log("FirstSceneManager: StaticContainer.bazStruct: " + StaticContainer.bazStruct.foo + StaticContainer.bazStruct.GetBar());
		}
	}
}
