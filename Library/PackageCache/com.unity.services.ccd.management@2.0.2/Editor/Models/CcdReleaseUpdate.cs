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
using Unity.Services.Ccd.Management.Http;



namespace Unity.Services.Ccd.Management.Models
{
    /// <summary>
    /// CcdReleaseUpdate model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.releaseUpdate")]
    public class CcdReleaseUpdate
    {
        /// <summary>
        /// Creates an instance of CcdReleaseUpdate.
        /// </summary>
        /// <param name="notes">notes param</param>
        [Preserve]
        public CcdReleaseUpdate(string notes = default)
        {
            Notes = notes;
        }

        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes{ get; }
    
    }
}

