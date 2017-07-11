using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Profiling;

public class Benchmark : MonoBehaviour {

	[SerializeField] private int count = 50000000;
	public int Count {
		get { return count; }
		set { count = value; }
	}
	protected int[] array;
	protected List<int> list;

	public void Awake() {
		var ranged = Enumerable.Range(0, this.Count);
		this.array = ranged.ToArray();
		this.list = ranged.ToList();
	}

	public void Start() {
		Profiler.BeginSample("UserSample:foreach(Array)");
		foreach (var item in this.array) { }
		Profiler.EndSample();

		Profiler.BeginSample("UserSample:foreach(List)");
		foreach (var item in this.list) { }
		Profiler.EndSample();

		Profiler.BeginSample("UserSample:for(Array)");
		for (int i = 0; i < this.array.Length; ++i) {
			var item = this.array[i];
		}
		Profiler.EndSample();

		Profiler.BeginSample("UserSample:for(List)");
		for (int i = 0; i < this.list.Count; ++i) {
			var item = this.list[i];
		}
		Profiler.EndSample();

		EditorApplication.isPaused = true;
		EditorApplication.isPlaying = false;
	}
}
