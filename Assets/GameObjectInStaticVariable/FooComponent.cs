using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kanonji.SmallExperiment.GameObjectInStaticVariable {

	public class FooComponent : MonoBehaviour {

		public string foo = "foo";
		[SerializeField]
		private string bar = "bar";
	}
}
