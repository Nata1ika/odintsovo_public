using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SliceEditor : MonoBehaviour
{
	[MenuItem("Tools/SetSliceController")]
	static void SetSliceController()
	{
		string build = "A";
		GameObject.Find("Slice_Controller_" + build);
	}
}
