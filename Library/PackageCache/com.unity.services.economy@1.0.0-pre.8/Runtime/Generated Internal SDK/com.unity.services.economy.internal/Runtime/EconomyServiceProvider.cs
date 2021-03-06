//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using UnityEngine;
using System.Threading.Tasks;

using Unity.Services.Economy.Internal.Apis.Currencies;

using Unity.Services.Economy.Internal.Apis.Inventory;

using Unity.Services.Economy.Internal.Apis.Purchases;

using Unity.Services.Economy.Internal.Http;
using Unity.Services.Core.Internal;
using Unity.Services.Authentication.Internal;

namespace Unity.Services.Economy.Internal
{
    internal class EconomyServiceProvider : IInitializablePackage
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void Register()
        {
            // Pass an instance of this class to Core
            var generatedPackageRegistry =
            CoreRegistry.Instance.RegisterPackage(new EconomyServiceProvider());
                // And specify what components it requires, or provides.
            generatedPackageRegistry.DependsOn<IAccessToken>();
;
        }

        public Task Initialize(CoreRegistry registry)
        {
            var httpClient = new HttpClient();

            var accessTokenEconomy = registry.GetServiceComponent<IAccessToken>();

            if (accessTokenEconomy != null)
            {
                EconomyService.Instance =
                    new InternalEconomyService(httpClient, registry.GetServiceComponent<IAccessToken>());
            }

            return Task.CompletedTask;
        }
    }

    /// <summary>
    /// InternalEconomyService
    /// </summary>
    internal class InternalEconomyService : IEconomyService
    {
        /// <summary>
        /// Constructor for InternalEconomyService
        /// </summary>
        /// <param name="httpClient">The HttpClient for InternalEconomyService.</param>
        /// <param name="accessToken">The Authentication token for the service.</param>
        public InternalEconomyService(HttpClient httpClient, IAccessToken accessToken = null)
        {
            
            CurrenciesApi = new CurrenciesApiClient(httpClient, accessToken);
            
            InventoryApi = new InventoryApiClient(httpClient, accessToken);
            
            PurchasesApi = new PurchasesApiClient(httpClient, accessToken);
            
            Configuration = new Configuration("https://economy.services.api.unity.com", 10, 4, null);
        }
        
        /// <summary> Instance of ICurrenciesApiClient interface</summary>
        public ICurrenciesApiClient CurrenciesApi { get; set; }
        
        /// <summary> Instance of IInventoryApiClient interface</summary>
        public IInventoryApiClient InventoryApi { get; set; }
        
        /// <summary> Instance of IPurchasesApiClient interface</summary>
        public IPurchasesApiClient PurchasesApi { get; set; }
        
        /// <summary> Configuration properties for the service.</summary>
        public Configuration Configuration { get; set; }
    }
}
