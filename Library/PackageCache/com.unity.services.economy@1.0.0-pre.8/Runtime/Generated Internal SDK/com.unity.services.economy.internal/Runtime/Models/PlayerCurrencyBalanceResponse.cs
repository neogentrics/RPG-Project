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
    /// PlayerCurrencyBalanceResponse model
    /// </summary>
    [Preserve]
    [DataContract(Name = "player_currency_balance_response")]
    internal class PlayerCurrencyBalanceResponse
    {
        /// <summary>
        /// Creates an instance of PlayerCurrencyBalanceResponse.
        /// </summary>
        /// <param name="results">List of Currency Balances.</param>
        /// <param name="links">links param</param>
        [Preserve]
        public PlayerCurrencyBalanceResponse(List<CurrencyBalanceResponse> results, PlayerCurrencyBalanceResponseLinks links)
        {
            Results = results;
            Links = links;
        }

        /// <summary>
        /// List of Currency Balances.
        /// </summary>
        [Preserve]
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public List<CurrencyBalanceResponse> Results{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public PlayerCurrencyBalanceResponseLinks Links{ get; }
    
    }
}

