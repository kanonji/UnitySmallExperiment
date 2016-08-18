using UnityEngine;

namespace Kanonji.SmallExperiment.VariableInitialized {

	public class VariableInitialized : MonoBehaviour {

		//[SerializeField] private float unityEngineRandomValue = UnityEngine.Random.value; //Got Error.
		//[SerializeField] private int unityEngineRandomRange = UnityEngine.Random.Range(1, 101); //Got Error.
		[SerializeField]
		private float systemRandomRange = (new System.Random()).Next(100);
		private static float staticUnityEngineRandomValue = UnityEngine.Random.value;
		private static float staticSystemRandomRange = (new System.Random()).Next(100);

		void Awake() {
			Debug.Log("staticUnityEngineRandomValue: " + staticUnityEngineRandomValue);
			Debug.Log("staticSystemRandomRange: " + staticSystemRandomRange);
		}
	}
}
