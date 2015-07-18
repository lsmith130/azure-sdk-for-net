// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.BackupServices.Models;

namespace Microsoft.Azure.Management.BackupServices
{
    /// <summary>
    /// Definition of Recovery Point operations for the Azure Backup extension.
    /// </summary>
    public partial interface IRecoveryPointOperations
    {
        /// <summary>
        /// Get the recovery point.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a CSMRecoveryPointOperationResponse.
        /// </returns>
        Task<CSMRecoveryPointOperationResponse> GetAsync(CustomRequestHeaders customRequestHeaders, string containerName, string itemName, string recoveryPointName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all recovery points.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a CSMRecoveryPointListOperationResponse.
        /// </returns>
        Task<CSMRecoveryPointListOperationResponse> ListAsync(CustomRequestHeaders customRequestHeaders, string containerName, string itemName, CancellationToken cancellationToken);
    }
}
