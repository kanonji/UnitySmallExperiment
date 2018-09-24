using UnityEngine;
using UnityEditor;

public class StaticInScriptableObjectViewer : EditorWindow {
	[MenuItem("Window/StaticInScriptableObjectViewer")]
	static void Open() {
		GetWindow<StaticInScriptableObjectViewer>();
	}

	void OnGUI() {
		GUIStyle style = new GUIStyle(GUI.skin.label);
		style.wordWrap = true;
		GUIStyle h1Style = new GUIStyle(GUI.skin.label);
		h1Style.fontSize = 24;
		GUIStyle h2Style = new GUIStyle(GUI.skin.label);
		h2Style.fontSize = 18;

		GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
		buttonStyle.margin.top += 10;

		if (GUILayout.Button("StaticInScriptableObject.foo = \"Changed\"", buttonStyle)) {
			StaticInScriptableObject.foo = "Changed";
		}
		GUILayout.BeginHorizontal();
		GUILayout.Label("StaticInScriptableObject.foo: ");
		EditorGUILayout.LabelField("", StaticInScriptableObject.foo);
		GUILayout.EndHorizontal();

		GUILayout.Box("", GUILayout.ExpandWidth(true), GUILayout.Height(1));

		GUILayout.Label("Importing scripts", h2Style);
		EditorGUILayout.LabelField("The static member is initialized when a script imported.", style);
		if (GUILayout.Button("Force re-import StaticInScriptableObject.cs", buttonStyle)) {
			AssetDatabase.ImportAsset("Assets/StaticInScriptableObject/StaticInScriptableObject.cs", ImportAssetOptions.ForceUpdate);
		}
		EditorGUI.indentLevel++;
		EditorGUILayout.LabelField("AssetDatabase.ImportAsset(\"Assets/StaticInScriptableObject/StaticInScriptableObject.cs\", ImportAssetOptions.ForceUpdate)", style);
		EditorGUI.indentLevel--;

		if (GUILayout.Button("Force re-import StaticInScriptableObjectViewer.cs", buttonStyle)) {
			AssetDatabase.ImportAsset("Assets/StaticInScriptableObject/Editor/StaticInScriptableObjectViewer.cs", ImportAssetOptions.ForceUpdate);
		}
		EditorGUI.indentLevel++;
		EditorGUILayout.LabelField("AssetDatabase.ImportAsset(\"Assets/StaticInScriptableObject/Editor/StaticInScriptableObjectViewer.cs\", ImportAssetOptions.ForceUpdate)", style);
		EditorGUI.indentLevel--;

		GUILayout.Box("", GUILayout.ExpandWidth(true), GUILayout.Height(1));

		GUILayout.Label("Importing non scripts", h2Style);
		EditorGUILayout.LabelField("Not to be initialized when not script asset imported.", style);
		if (GUILayout.Button("Force re-import prefab", buttonStyle)) {
			AssetDatabase.ImportAsset("Assets/StaticInScriptableObject/GameObject.prefab", ImportAssetOptions.ForceUpdate);
		}
		EditorGUI.indentLevel++;
		EditorGUILayout.LabelField("AssetDatabase.ImportAsset(\"Assets/StaticInScriptableObject/GameObject.prefab\", ImportAssetOptions.ForceUpdate)", style);
		EditorGUI.indentLevel--;
	}

	void Update() {
		this.Repaint();
	}
}
