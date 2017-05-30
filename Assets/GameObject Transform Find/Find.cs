using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find : MonoBehaviour {


	[SerializeField] private GameObject parent;
	public GameObject Parent {
		get { return parent; }
		set { parent = value; }
	}
	void Start () {
		this.FindByGameObjectMethod();
		this.FindByTransformMethod();
		this.TransformFindIsNormallyForChild();
		this.TransformFindBehavesGameObjectFindWithSlash();
	}

	public void FindByGameObjectMethod() {
		var goFindActive = GameObject.Find("Active Cube");
		var goFindInactive = GameObject.Find("Inactive Cylinder");
		Debug.Log("GameObject.Find(\"Active Cube\"): " + goFindActive);
		Debug.Log("GameObject.Find(\"Inactive Cylinder\")" + goFindInactive); // null
	}

	public void FindByTransformMethod() {
		//Transform.Find() is not static method.
		//var goFindActive = Transform.Find("Active Cube");
		//var goFindInactive = Transform.Find("Inactive Cylinder");

		var transformFindActive = this.Parent.transform.Find("Active Child");
		var transformFindInactive = this.Parent.transform.Find("Inactive Child");
		Debug.Log("Parent.transform.Find(\"Active Child\"): " + transformFindActive);
		Debug.Log("Parent.transform.Find(\"Inactive Child\")" + transformFindInactive);
	}

	public void TransformFindIsNormallyForChild() {
		var transformFindCube = this.Parent.transform.Find("Active Cube");
		Debug.Log("Parent.transform.Find(\"Active Cube\"): " + transformFindCube); // null
	}

	public void TransformFindBehavesGameObjectFindWithSlash() {
		var transformFindCube = this.Parent.transform.Find("/Active Cube");
		Debug.Log("Parent.transform.Find(\"/Active Cube\"): " + transformFindCube);

		var transformFindInactive = this.Parent.transform.Find("/Inactive Cylinder");
		Debug.Log("Parent.transform.Find(\"/Inactive Cylinder\"): " + transformFindInactive); // null

	}
}
