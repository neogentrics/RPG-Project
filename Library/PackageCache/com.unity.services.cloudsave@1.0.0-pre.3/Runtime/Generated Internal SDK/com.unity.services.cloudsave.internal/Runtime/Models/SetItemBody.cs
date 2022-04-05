//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.CloudSave.Internal.Http;



namespace Unity.Services.CloudSave.Internal.Models
{
    /// <summary>
    /// Request type for a Data Item to store in the Cloud Save service.
    /// <param name="key">The key will be created if it does not exist, provided the item limit has not been reached for this entity.</param>
    /// <param name="value">Any JSON serializable structure</param>
    /// <param name="writeLock">Enforces conflict checking when updating an existing data item. This field should be omitted when creating a new data item. When updating an existing item, omitting this field ignores write conflicts. When present, an error response will be returned if the writeLock in the request does not match the stored writeLock.</param>
    /// </summary>

    [Preserve]
    [DataContract(Name = "set-item-body")]
    internal class SetItemBody
    {
        /// <summary>
        /// Request type for a Data Item to store in the Cloud Save service.
        /// </summary>
        /// <param name="key">The key will be created if it does not exist, provided the item limit has not been reached for this entity.</param>
        /// <param name="value">Any JSON serializable structure</param>
        /// <param name="writeLock">Enforces conflict checking when updating an existing data item. This field should be omitted when creating a new data item. When updating an existing item, omitting this field ignores write conflicts. When present, an error response will be returned if the writeLock in the request does not match the stored writeLock.</param>
        [Preserve]
        public SetItemBody(string key, object value, string writeLock = default)
        {
            Key = key;
            Value = new JsonObject(value);
            WriteLock = writeLock;
        }

        /// <summary>
        /// The key will be created if it does not exist, provided the item limit has not been reached for this entity.
        /// </summary>
        [Preserve]
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key{ get; }
        /// <summary>
        /// Any JSON serializable structure
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(JsonObjectConverter))]
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public JsonObject Value{ get; }
        /// <summary>
        /// Enforces conflict checking when updating an existing data item. This field should be omitted when creating a new data item. When updating an existing item, omitting this field ignores write conflicts. When present, an error response will be returned if the writeLock in the request does not match the stored writeLock.
        /// </summary>
        [Preserve]
        [DataMember(Name = "writeLock", EmitDefaultValue = false)]
        public string WriteLock{ get; }
    
    }
}

