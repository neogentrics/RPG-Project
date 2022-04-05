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
using Unity.Services.Economy.Internal.Http;



namespace Unity.Services.Economy.Internal.Models
{
    /// <summary>
    /// An error response sent back upon player inventory item conflict
    /// </summary>
    [Preserve]
    [DataContract(Name = "error-response-conflict-inventory-delete")]
    internal class ErrorResponseConflictInventoryDelete
    {
        /// <summary>
        /// An error response sent back upon player inventory item conflict
        /// </summary>
        /// <param name="type">type param</param>
        /// <param name="title">title param</param>
        /// <param name="status">e.g 409</param>
        /// <param name="code">e.g. 10204</param>
        /// <param name="detail">detail param</param>
        /// <param name="data">data param</param>
        /// <param name="instance">instance param</param>
        [Preserve]
        public ErrorResponseConflictInventoryDelete(string type, string title, int status, int code, string detail, ErrorResponseConflictInventoryDeleteData data, string instance = default)
        {
            Type = type;
            Title = title;
            Status = status;
            Code = code;
            Detail = detail;
            Instance = instance;
            Data = data;
        }

        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title{ get; }
        /// <summary>
        /// e.g 409
        /// </summary>
        [Preserve]
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public int Status{ get; }
        /// <summary>
        /// e.g. 10204
        /// </summary>
        [Preserve]
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public int Code{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "detail", IsRequired = true, EmitDefaultValue = true)]
        public string Detail{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "instance", EmitDefaultValue = false)]
        public string Instance{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public ErrorResponseConflictInventoryDeleteData Data{ get; }
    
    }
}

