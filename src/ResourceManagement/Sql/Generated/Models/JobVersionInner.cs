// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// A job version.
    /// </summary>
    public partial class JobVersionInner : ProxyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the JobVersionInner class.
        /// </summary>
        public JobVersionInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobVersionInner class.
        /// </summary>
        public JobVersionInner(string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}