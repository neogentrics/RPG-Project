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
    /// CcdBucketPermissions model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.bucketPermissions")]
    public class CcdBucketPermissions
    {
        /// <summary>
        /// Creates an instance of CcdBucketPermissions.
        /// </summary>
        /// <param name="bucketPromote">bucketPromote param</param>
        /// <param name="bucketRead">bucketRead param</param>
        /// <param name="bucketRelease">bucketRelease param</param>
        /// <param name="bucketWrite">bucketWrite param</param>
        [Preserve]
        public CcdBucketPermissions(bool bucketPromote = default, bool bucketRead = default, bool bucketRelease = default, bool bucketWrite = default)
        {
            BucketPromote = bucketPromote;
            BucketRead = bucketRead;
            BucketRelease = bucketRelease;
            BucketWrite = bucketWrite;
        }

        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "bucket_promote", EmitDefaultValue = true)]
        public bool BucketPromote{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "bucket_read", EmitDefaultValue = true)]
        public bool BucketRead{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "bucket_release", EmitDefaultValue = true)]
        public bool BucketRelease{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "bucket_write", EmitDefaultValue = true)]
        public bool BucketWrite{ get; }
    
    }
}

