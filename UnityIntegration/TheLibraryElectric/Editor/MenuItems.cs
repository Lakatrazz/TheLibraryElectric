using UnityEngine;
using UnityEditor;
using TheLibraryElectric.Rigidbodies;
using TheLibraryElectric.PlayerUtil;

public class MenuItems : Editor
{
	[MenuItem("GameObject/The Library Electric/Gravity Chamber", false, 10)]
	static void CreateGravityChamber(MenuCommand menuCommand)
	{
		GameObject go = new GameObject("Gravity Chamber");
		GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
		BoxCollider bc = go.AddComponent<BoxCollider>();
		bc.isTrigger = true;
		go.AddComponent<GravityChamber>();
		Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
		Selection.activeObject = go;
	}
	[MenuItem("GameObject/The Library Electric/Water Zone", false, 10)]
	static void CreateWaterZone(MenuCommand menuCommand)
	{
		GameObject go = new GameObject("Water Zone");
		GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
		BoxCollider bc = go.AddComponent<BoxCollider>();
		bc.isTrigger = true;
		go.AddComponent<WaterZone>();
		Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
		Selection.activeObject = go;
	}
	[MenuItem("GameObject/The Library Electric/Ragdoll Zone", false, 10)]
	static void CreateRagdollZone(MenuCommand menuCommand)
	{
		GameObject go = new GameObject("Ragdoll Zone");
		GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
		BoxCollider bc = go.AddComponent<BoxCollider>();
		bc.isTrigger = true;
		go.AddComponent<RagdollZone>();
		Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
		Selection.activeObject = go;
	}
}
