﻿using UnityEngine;
using UnityEditor;
using Zelude;

namespace Zelude.Editor
{
	[CustomPropertyDrawer(typeof(RequireInterfaceAttribute))]
	public class RequireInterfaceAttributeDrawer : PropertyDrawer
	{
		private RequireInterfaceAttribute _requireInterfaceAttribute => (RequireInterfaceAttribute)attribute;

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			InterfaceObjectArguments args = new InterfaceObjectArguments(fieldInfo.FieldType, _requireInterfaceAttribute.InterfaceType);
			InterfaceObjectUtility.OnGUI(position, property, label, args);
		}
	}
}