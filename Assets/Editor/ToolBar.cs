﻿using UnityEngine;
using UnityEditor;
public class Toolbar
{
	public static void OnGUI (StateMachine stateMachine)
	{
		EditorGUILayout.BeginHorizontal (EditorStyles.toolbar);
		EditorGUILayout.LabelField ("Example Grid Window");
		if (GUILayout.Button ("Add State",EditorStyles.toolbarButton)) {
			stateMachine.AddState("new State");
		}
		EditorGUILayout.EndHorizontal ();
	}
}
