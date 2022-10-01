﻿//-----------------------------------------------------
//            Arbor 3: FSM & BT Graph Editor
//		  Copyright(c) 2014-2021 caitsithware
//-----------------------------------------------------
using UnityEngine;

namespace Arbor.Examples
{
	/// <summary>
	/// Data class for Variable. (Generated by Variable Generator)
	/// </summary>
	[System.Serializable]
	[RenamedFrom("Arbor.Example.VariableExampleData")]
	public sealed class VariableExampleData
	{
		// Declare Serialize Fields

		/// <summary>
		/// string field
		/// </summary>
		public string name;

		/// <summary>
		/// Sprite field
		/// </summary>
		public Sprite icon;
	}

	/// <summary>
	/// Flexible field for VariableExampleData.  (Generated by Variable Generator)
	/// </summary>
	[System.Serializable]
	public sealed class FlexibleVariableExampleData : FlexibleField<VariableExampleData>
	{
		/// <summary>
		/// Constant specification constructor
		/// </summary>
		/// <param name="value">constant value</param>
		public FlexibleVariableExampleData(VariableExampleData value) : base(value)
		{
		}

		/// <summary>
		/// Parameter reference specification constructor
		/// </summary>
		/// <param name="parameter">parameter reference value</param>
		public FlexibleVariableExampleData(AnyParameterReference parameter) : base(parameter)
		{
		}

		/// <summary>
		/// Data input slot specification constructor
		/// </summary>
		/// <param name="slot">data input slot</param>
		public FlexibleVariableExampleData(InputSlotAny slot) : base(slot)
		{
		}

		/// <summary>
		/// Explicit type conversion
		/// </summary>
		/// <param name="flexible">flexible field</param>
		public static explicit operator VariableExampleData(FlexibleVariableExampleData flexible)
		{
			return flexible.value;
		}

		/// <summary>
		/// Explicit type conversion
		/// </summary>
		/// <param name="value">data value</param>
		public static explicit operator FlexibleVariableExampleData(VariableExampleData value)
		{
			return new FlexibleVariableExampleData(value);
		}
	}

	/// <summary>
	/// Input slot for VariableExampleData.  (Generated by Variable Generator)
	/// </summary>
	[System.Serializable]
	public sealed class InputSlotVariableExampleData : InputSlot<VariableExampleData>
	{
	}

	/// <summary>
	/// Output slot for VariableExampleData.  (Generated by Variable Generator)
	/// </summary>
	[System.Serializable]
	public sealed class OutputSlotVariableExampleData : OutputSlot<VariableExampleData>
	{
	}

	/// <summary>
	/// Variable class for parameterizing VariableExampleData.  (Generated by Variable Generator)
	/// </summary>
	[AddVariableMenu("Examples/VariableExampleData")]
	[BehaviourTitle("VariableExampleData")]
	[AddComponentMenu("")]
	public sealed class VariableExampleDataVariable : Variable<VariableExampleData>
	{
	}
}