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
using Unity.Services.Relay.Qos.Http;



namespace Unity.Services.Relay.Qos.Models
{
    /// <summary>
    /// QoSServersResponseBody model
    /// <param name="data">data param</param>
    /// </summary>

    [Preserve]
    [DataContract(Name = "QoSServersResponseBody")]
    internal class QoSServersResponseBody
    {
        /// <summary>
        /// Creates an instance of QoSServersResponseBody.
        /// </summary>
        /// <param name="data">data param</param>
        [Preserve]
        public QoSServersResponseBody(QoSServersList data)
        {
            Data = data;
        }

        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public QoSServersList Data{ get; }
    
    }
}

