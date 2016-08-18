using UnityEngine;
using System.Collections;

namespace Kanonji.SmallExperiment.NullCoalescingOperatorAndExposedToInspector {

	public class FooBehaviour : MonoBehaviour {

		[SerializeField] protected GameObject exposed;
		public GameObject Exposed { get { return exposed ?? gameObject; } }
		protected GameObject hidden;
		public GameObject Hidden { get { return hidden ?? gameObject; } }

		[SerializeField] protected GameObject exposedFixed;
		public GameObject ExposedFixed { get { if (null == exposedFixed) exposedFixed = null;return exposedFixed ?? gameObject; } }

		[SerializeField] protected string exposedString;
		public string ExposedString { get { return exposedString ?? "foo"; } }

		//[SerializeField] protected int exposedInt;
		//public int ExposedInt { get { return exposedInt ?? 100; } } //null coalescing operator cannot be applied to int.

		// Use this for initialization
		void Start() {
			Debug.Log("Exposed will be null: " + Exposed);
			Debug.Log("Hidden won't be null: " + Hidden);
			Debug.Log("ExposedFixed won't be null: " + ExposedFixed);
			Debug.Log("ExposedString will be empty string: " + ExposedString);
		}
	}
}
