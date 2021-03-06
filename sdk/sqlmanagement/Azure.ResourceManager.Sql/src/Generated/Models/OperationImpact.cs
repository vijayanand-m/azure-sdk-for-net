// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The impact of an operation, both in absolute and relative terms. </summary>
    public partial class OperationImpact
    {
        /// <summary> Initializes a new instance of OperationImpact. </summary>
        internal OperationImpact()
        {
        }

        /// <summary> Initializes a new instance of OperationImpact. </summary>
        /// <param name="name"> The name of the impact dimension. </param>
        /// <param name="unit"> The unit in which estimated impact to dimension is measured. </param>
        /// <param name="changeValueAbsolute"> The absolute impact to dimension. </param>
        /// <param name="changeValueRelative"> The relative impact to dimension (null if not applicable). </param>
        internal OperationImpact(string name, string unit, double? changeValueAbsolute, double? changeValueRelative)
        {
            Name = name;
            Unit = unit;
            ChangeValueAbsolute = changeValueAbsolute;
            ChangeValueRelative = changeValueRelative;
        }

        /// <summary> The name of the impact dimension. </summary>
        public string Name { get; }
        /// <summary> The unit in which estimated impact to dimension is measured. </summary>
        public string Unit { get; }
        /// <summary> The absolute impact to dimension. </summary>
        public double? ChangeValueAbsolute { get; }
        /// <summary> The relative impact to dimension (null if not applicable). </summary>
        public double? ChangeValueRelative { get; }
    }
}
