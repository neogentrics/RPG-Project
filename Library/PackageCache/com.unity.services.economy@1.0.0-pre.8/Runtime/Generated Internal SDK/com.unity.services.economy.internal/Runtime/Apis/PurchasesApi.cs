//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System.Threading.Tasks;
using System.Collections.Generic;
using Unity.Services.Economy.Internal.Models;
using Unity.Services.Economy.Internal.Http;
using Unity.Services.Authentication.Internal;
using Unity.Services.Economy.Internal.Purchases;

namespace Unity.Services.Economy.Internal.Apis.Purchases
{
    /// <summary>
    /// Interface for the PurchasesApiClient
    /// </summary>
    internal interface IPurchasesApiClient
    {
            /// <summary>
            /// Async Operation.
            /// Make purchase.
            /// </summary>
            /// <param name="request">Request object for MakeVirtualPurchase.</param>
            /// <param name="operationConfiguration">Configuration for MakeVirtualPurchase.</param>
            /// <returns>Task for a Response object containing status code, headers, and PlayerPurchaseVirtualResponse object.</returns>
            /// <exception cref="Unity.Services.Economy.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<PlayerPurchaseVirtualResponse>> MakeVirtualPurchaseAsync(MakeVirtualPurchaseRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Redeem Apple App Store Purchase.
            /// </summary>
            /// <param name="request">Request object for RedeemAppleAppStorePurchase.</param>
            /// <param name="operationConfiguration">Configuration for RedeemAppleAppStorePurchase.</param>
            /// <returns>Task for a Response object containing status code, headers, and PlayerPurchaseAppleappstoreResponse object.</returns>
            /// <exception cref="Unity.Services.Economy.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<PlayerPurchaseAppleappstoreResponse>> RedeemAppleAppStorePurchaseAsync(RedeemAppleAppStorePurchaseRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Redeem Google Play Purchase.
            /// </summary>
            /// <param name="request">Request object for RedeemGooglePlayPurchase.</param>
            /// <param name="operationConfiguration">Configuration for RedeemGooglePlayPurchase.</param>
            /// <returns>Task for a Response object containing status code, headers, and PlayerPurchaseGoogleplaystoreResponse object.</returns>
            /// <exception cref="Unity.Services.Economy.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<PlayerPurchaseGoogleplaystoreResponse>> RedeemGooglePlayPurchaseAsync(RedeemGooglePlayPurchaseRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="IPurchasesApiClient"/>
    internal class PurchasesApiClient : BaseApiClient, IPurchasesApiClient
    {
        private IAccessToken _accessToken;
        private const int _baseTimeout = 10;
        private Configuration _configuration;
        /// <summary>
        /// Accessor for the client configuration object. This returns a merge
        /// between the current configuration and the global configuration to
        /// ensure the correct combination of headers and a base path (if it is
        /// set) are returned.
        /// </summary>
        public Configuration Configuration
        {
            get {
                // We return a merge between the current configuration and the
                // global configuration to ensure we have the correct
                // combination of headers and a base path (if it is set).
                Configuration globalConfiguration = new Configuration("https://economy.services.api.unity.com", 10, 4, null);
                if (EconomyService.Instance != null)
                {
                    globalConfiguration = EconomyService.Instance.Configuration;
                }
                return Configuration.MergeConfigurations(_configuration, globalConfiguration);
            }
        }

        /// <summary>
        /// PurchasesApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for PurchasesApiClient.</param>
        /// <param name="accessToken">The Authentication token for the client.</param>
        /// <param name="configuration"> PurchasesApiClient Configuration object.</param>
        public PurchasesApiClient(IHttpClient httpClient,
            IAccessToken accessToken,
            Configuration configuration = null) : base(httpClient)
        {
            // We don't need to worry about the configuration being null at
            // this stage, we will check this in the accessor.
            _configuration = configuration;

            _accessToken = accessToken;
        }


        /// <summary>
        /// Async Operation.
        /// Make purchase.
        /// </summary>
        /// <param name="request">Request object for MakeVirtualPurchase.</param>
        /// <param name="operationConfiguration">Configuration for MakeVirtualPurchase.</param>
        /// <returns>Task for a Response object containing status code, headers, and PlayerPurchaseVirtualResponse object.</returns>
        /// <exception cref="Unity.Services.Economy.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<PlayerPurchaseVirtualResponse>> MakeVirtualPurchaseAsync(MakeVirtualPurchaseRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(PlayerPurchaseVirtualResponse)   },{"400", typeof(MakeVirtualPurchase400OneOf)   },{"403", typeof(BasicErrorResponse)   },{"404", typeof(BasicErrorResponse)   },{"422", typeof(BasicErrorResponse)   },{"429", typeof(BasicErrorResponse)   },{"503", typeof(BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<PlayerPurchaseVirtualResponse>(response, statusCodeToTypeMap);
            return new Response<PlayerPurchaseVirtualResponse>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Redeem Apple App Store Purchase.
        /// </summary>
        /// <param name="request">Request object for RedeemAppleAppStorePurchase.</param>
        /// <param name="operationConfiguration">Configuration for RedeemAppleAppStorePurchase.</param>
        /// <returns>Task for a Response object containing status code, headers, and PlayerPurchaseAppleappstoreResponse object.</returns>
        /// <exception cref="Unity.Services.Economy.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<PlayerPurchaseAppleappstoreResponse>> RedeemAppleAppStorePurchaseAsync(RedeemAppleAppStorePurchaseRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(PlayerPurchaseAppleappstoreResponse)   },{"400", typeof(MakeVirtualPurchase400OneOf)   },{"403", typeof(BasicErrorResponse)   },{"404", typeof(BasicErrorResponse)   },{"422", typeof(RedeemAppleAppStorePurchase422OneOf)   },{"429", typeof(BasicErrorResponse)   },{"503", typeof(BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<PlayerPurchaseAppleappstoreResponse>(response, statusCodeToTypeMap);
            return new Response<PlayerPurchaseAppleappstoreResponse>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Redeem Google Play Purchase.
        /// </summary>
        /// <param name="request">Request object for RedeemGooglePlayPurchase.</param>
        /// <param name="operationConfiguration">Configuration for RedeemGooglePlayPurchase.</param>
        /// <returns>Task for a Response object containing status code, headers, and PlayerPurchaseGoogleplaystoreResponse object.</returns>
        /// <exception cref="Unity.Services.Economy.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<PlayerPurchaseGoogleplaystoreResponse>> RedeemGooglePlayPurchaseAsync(RedeemGooglePlayPurchaseRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(PlayerPurchaseGoogleplaystoreResponse)   },{"400", typeof(MakeVirtualPurchase400OneOf)   },{"403", typeof(BasicErrorResponse)   },{"404", typeof(BasicErrorResponse)   },{"422", typeof(RedeemGooglePlayPurchase422OneOf)   },{"429", typeof(BasicErrorResponse)   },{"503", typeof(BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<PlayerPurchaseGoogleplaystoreResponse>(response, statusCodeToTypeMap);
            return new Response<PlayerPurchaseGoogleplaystoreResponse>(response, handledResponse);
        }

    }
}