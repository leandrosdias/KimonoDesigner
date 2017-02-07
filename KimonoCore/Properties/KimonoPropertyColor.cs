﻿using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines a `KimonoProperty` that represents a `KimonoColor` value.
	/// </summary>
	public class KimonoPropertyColor : KimonoProperty
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The `KimonoColor` value.</value>
		public KimonoColor Value { get; set; } = new KimonoColor();
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyText"/> class.
		/// </summary>
		public KimonoPropertyColor()
		{
			// Initialize
			Name = "Color Property";
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Evaluate this instance by executing any attached Obi Script to get the new
		/// value for the `KimonoProperty`.
		/// </summary>
		/// <returns>The result of the Obi Script execution as a `ObiScriptResult`.</returns>
		public override ObiScriptResult Evaluate()
		{
			var scriptResult = new ObiScriptResult();

			// Is there a script attached?
			if (IsObiScriptValue)
			{
				// TODO: Execute the script to get the new value
			}

			// Return the result of executing the script
			return scriptResult;
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts this `KimonoProperty` to a `KimonoColor`.
		/// </summary>
		/// <returns>The color.</returns>
		public override KimonoColor ToColor()
		{
			return Value;
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public override KimonoProperty Clone()
		{
			// Make copy
			var newProperty = new KimonoPropertyColor()
			{
				Name = this.Name,
				Usage = this.Usage,
				IsObiScriptValue = this.IsObiScriptValue,
				ObiScript = this.ObiScript,
				Value = this.Value.Clone()
			};

			// Return clone
			return newProperty;
		}
		#endregion
	}
}