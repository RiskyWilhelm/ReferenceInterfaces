﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zelude
{
	public class RequireInterfaceAttribute : PropertyAttribute
	{
		public readonly Type InterfaceType;


		public RequireInterfaceAttribute(Type interfaceType)
		{
			Debug.Assert(interfaceType.IsInterface, $"{nameof(interfaceType)} needs to be an interface.");
			InterfaceType = interfaceType;
		}
	}
}