// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;

    /// <summary>
    /// ReplicationsOperations operations.
    /// </summary>
    public partial interface IReplicationsOperations
    {
        /// <summary>
        /// Gets the properties of the specified replication.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='replicationName'>
        /// The name of the replication.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Replication>> GetWithHttpMessagesAsync(string resourceGroupName, string registryName, string replicationName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a replication for a container registry with the specified
        /// parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='replicationName'>
        /// The name of the replication.
        /// </param>
        /// <param name='replication'>
        /// The parameters for creating a replication.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Replication>> CreateWithHttpMessagesAsync(string resourceGroupName, string registryName, string replicationName, Replication replication, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a replication from a container registry.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='replicationName'>
        /// The name of the replication.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string registryName, string replicationName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a replication for a container registry with the specified
        /// parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='replicationName'>
        /// The name of the replication.
        /// </param>
        /// <param name='tags'>
        /// The tags for the replication.
        /// </param>
        /// <param name='regionEndpointEnabled'>
        /// Specifies whether the replication's regional endpoint is enabled.
        /// Requests will not be routed to a replication whose regional
        /// endpoint is disabled, however its data will continue to be synced
        /// with other replications.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Replication>> UpdateWithHttpMessagesAsync(string resourceGroupName, string registryName, string replicationName, IDictionary<string, string> tags = default(IDictionary<string, string>), bool? regionEndpointEnabled = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all the replications for the specified container registry.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<IPage<Replication>>> ListWithHttpMessagesAsync(string resourceGroupName, string registryName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a replication for a container registry with the specified
        /// parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='replicationName'>
        /// The name of the replication.
        /// </param>
        /// <param name='replication'>
        /// The parameters for creating a replication.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Replication>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string registryName, string replicationName, Replication replication, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a replication from a container registry.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='replicationName'>
        /// The name of the replication.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string registryName, string replicationName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a replication for a container registry with the specified
        /// parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='replicationName'>
        /// The name of the replication.
        /// </param>
        /// <param name='tags'>
        /// The tags for the replication.
        /// </param>
        /// <param name='regionEndpointEnabled'>
        /// Specifies whether the replication's regional endpoint is enabled.
        /// Requests will not be routed to a replication whose regional
        /// endpoint is disabled, however its data will continue to be synced
        /// with other replications.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Replication>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string registryName, string replicationName, IDictionary<string, string> tags = default(IDictionary<string, string>), bool? regionEndpointEnabled = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all the replications for the specified container registry.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<IPage<Replication>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
