// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Result of the request to list Microsoft.Resources operations. It contains a list of operations and a URL link to get the next set of results. </summary>
    internal partial class OperationListResultAutoGenerated3
    {
        /// <summary> Initializes a new instance of OperationListResultAutoGenerated3. </summary>
        internal OperationListResultAutoGenerated3()
        {
            Value = new ChangeTrackingList<OperationAutoGenerated3>();
        }

        /// <summary> List of Microsoft.Resources operations. </summary>
        public IReadOnlyList<OperationAutoGenerated3> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
