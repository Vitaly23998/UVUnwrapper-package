using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{
[ExecuteInEditMode]
	public class AutoUVUnwrapping : MonoBehaviour
	{
		[MenuItem("Utils/Mesh/Generate Lightmap UVs for Selection")]
		public static void GenerateLightmapUVs()
		{
			GameObject[] selectedObjects = Selection.gameObjects;
			foreach (GameObject selectedObject in selectedObjects)
			{
				MeshFilter meshFilter = selectedObject.GetComponent<MeshFilter>();
				if (meshFilter != null)
				{
					Unwrapping.GenerateSecondaryUVSet(meshFilter.sharedMesh);
				}
			}
		}
	}
}