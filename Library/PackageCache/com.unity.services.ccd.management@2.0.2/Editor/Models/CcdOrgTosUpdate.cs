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
    /// CcdOrgTosUpdate model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.orgTosUpdate")]
    public class CcdOrgTosUpdate
    {
        /// <summary>
        /// Creates an instance of CcdOrgTosUpdate.
        /// </summary>
        /// <param name="tosVersion">tosVersion param</param>
        [Preserve]
        public CcdOrgTosUpdate(int tosVersion = default)
        {
            TosVersion = tosVersion;
        }

        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "tos_version", EmitDefaultValue = false)]
        public int TosVersion{ get; }
    
    }
}

