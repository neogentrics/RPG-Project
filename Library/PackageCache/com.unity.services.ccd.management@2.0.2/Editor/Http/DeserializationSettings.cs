//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;

namespace Unity.Services.Ccd.Management.Http
{   
    /// <summary>Enum for how handling missing members when deserializing.</summary>
    public enum MissingMemberHandling
    {
        /// <summary>Throw an error when a member is missing</summary>
        Error,
        /// <summary>Ignore missing members</summary>
        Ignore
    }

    /// <summary>
    /// DeserializationSettings class.
    /// </summary>
    public class DeserializationSettings
    {
        /// <summary>MissingMemberHandling is set to Error by default.</summary>
        public MissingMemberHandling MissingMemberHandling = MissingMemberHandling.Error;
    }
    
}
