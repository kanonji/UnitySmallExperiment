using UnityEngine;

namespace Kanonji.SmallExperiment.VariableInitialized {

	public class VariableInitialized : MonoBehaviour {
		//UnityException: get_value is not allowed to be called from a MonoBehaviour constructor(or instance field initializer), call it in Awake or Start instead.Called from MonoBehaviour 'VariableInitialized'.
		//See "Script Serialization" page in the Unity Manual for further details.
		//[SerializeField] private float unityEngineRandomValue = UnityEngine.Random.value;

		//UnityException: RandomRangeInt is not allowed to be called from a MonoBehaviour constructor (or instance field initializer), call it in Awake or Start instead. Called from MonoBehaviour 'VariableInitialized'.
		//See "Script Serialization" page in the Unity Manual for further details.
		//[SerializeField] private int unityEngineRandomRange = UnityEngine.Random.Range(1, 101);

		[SerializeField] private float systemRandomRange = (new System.Random()).Next(100);

		public float publicSystemRandomRange = (new System.Random()).Next(100);

		//UnityException: get_value is not allowed to be called from a MonoBehaviour constructor (or instance field initializer), call it in Awake or Start instead. Called from MonoBehaviour 'VariableInitialized'.
		//See "Script Serialization" page in the Unity Manual for further details.
		//private static float staticUnityEngineRandomValue = UnityEngine.Random.value;

		//UnityException: RandomRangeInt is not allowed to be called from a MonoBehaviour constructor(or instance field initializer), call it in Awake or Start instead.Called from MonoBehaviour 'VariableInitialized' on game object 'Prefab'.
		//See "Script Serialization" page in the Unity Manual for further details.
		//private static int staticUnityEngineRandomRange = UnityEngine.Random.Range(1, 101);

		private static float staticSystemRandomRange = (new System.Random()).Next(100);

		void Awake() {
			Debug.Log(this.gameObject.name + ": systemRandomRange: " + systemRandomRange);
			Debug.Log(this.gameObject.name + ": publicSystemRandomRange: " + publicSystemRandomRange);
			Debug.Log(this.gameObject.name + ": staticSystemRandomRange: " + staticSystemRandomRange);
		}
	}
}
