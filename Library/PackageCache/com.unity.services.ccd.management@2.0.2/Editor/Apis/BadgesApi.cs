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
using Unity.Services.Ccd.Management.Models;
using Unity.Services.Ccd.Management.Http;
using Unity.Services.Ccd.Management.Badges;

namespace Unity.Services.Ccd.Management.Apis.Badges
{
    /// <summary>
    /// Interface for the BadgesApiClient
    /// </summary>
    internal interface IBadgesApiClient
    {
            /// <summary>
            /// Async Operation.
            /// Delete a badge.
            /// </summary>
            /// <param name="request">Request object for DeleteBadge.</param>
            /// <param name="operationConfiguration">Configuration for DeleteBadge.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Ccd.Management.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> DeleteBadgeAsync(Unity.Services.Ccd.Management.Badges.DeleteBadgeRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get badge.
            /// </summary>
            /// <param name="request">Request object for GetBadge.</param>
            /// <param name="operationConfiguration">Configuration for GetBadge.</param>
            /// <returns>Task for a Response object containing status code, headers, and CcdBadge object.</returns>
            /// <exception cref="Unity.Services.Ccd.Management.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<CcdBadge>> GetBadgeAsync(Unity.Services.Ccd.Management.Badges.GetBadgeRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get badges.
            /// </summary>
            /// <param name="request">Request object for ListBadges.</param>
            /// <param name="operationConfiguration">Configuration for ListBadges.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;CcdBadge&gt; object.</returns>
            /// <exception cref="Unity.Services.Ccd.Management.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<CcdBadge>>> ListBadgesAsync(Unity.Services.Ccd.Management.Badges.ListBadgesRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Assign a badge.
            /// </summary>
            /// <param name="request">Request object for UpdateBadge.</param>
            /// <param name="operationConfiguration">Configuration for UpdateBadge.</param>
            /// <returns>Task for a Response object containing status code, headers, and CcdBadge object.</returns>
            /// <exception cref="Unity.Services.Ccd.Management.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<CcdBadge>> UpdateBadgeAsync(Unity.Services.Ccd.Management.Badges.UpdateBadgeRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="IBadgesApiClient"/>
    internal class BadgesApiClient : BaseApiClient, IBadgesApiClient
    {
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
                Configuration globalConfiguration = new Configuration("https://services.unity.com", 10, 4, null);
                if (CcdManagementService.Instance != null)
                {
                    globalConfiguration = CcdManagementService.Instance.Configuration;
                }
                return Configuration.MergeConfigurations(_configuration, globalConfiguration);
            }
            set { _configuration = value; }
        }

        /// <summary>
        /// BadgesApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for BadgesApiClient.</param>
        /// <param name="configuration"> BadgesApiClient Configuration object.</param>
        public BadgesApiClient(IHttpClient httpClient,
            Configuration configuration = null) : base(httpClient)
        {
            // We don't need to worry about the configuration being null at
            // this stage, we will check this in the accessor.
            _configuration = configuration;

            
        }


        /// <summary>
        /// Async Operation.
        /// Delete a badge.
        /// </summary>
        /// <param name="request">Request object for DeleteBadge.</param>
        /// <param name="operationConfiguration">Configuration for DeleteBadge.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Ccd.Management.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> DeleteBadgeAsync(Unity.Services.Ccd.Management.Badges.DeleteBadgeRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"204",  null },{"400", typeof(Models.ValidationError)   },{"401", typeof(Models.AuthenticationError)   },{"403", typeof(Models.AuthorizationError)   },{"404", typeof(Models.NotFoundError)   },{"429", typeof(Models.TooManyRequestsError)   },{"500", typeof(Models.InternalServerError)   },{"503", typeof(Models.ServiceUnavailableError)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("DELETE",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }


        /// <summary>
        /// Async Operation.
        /// Get badge.
        /// </summary>
        /// <param name="request">Request object for GetBadge.</param>
        /// <param name="operationConfiguration">Configuration for GetBadge.</param>
        /// <returns>Task for a Response object containing status code, headers, and CcdBadge object.</returns>
        /// <exception cref="Unity.Services.Ccd.Management.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<CcdBadge>> GetBadgeAsync(Unity.Services.Ccd.Management.Badges.GetBadgeRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(CcdBadge)   },{"400", typeof(Models.ValidationError)   },{"401", typeof(Models.AuthenticationError)   },{"403", typeof(Models.AuthorizationError)   },{"404", typeof(Models.NotFoundError)   },{"429", typeof(Models.TooManyRequestsError)   },{"500", typeof(Models.InternalServerError)   },{"503", typeof(Models.ServiceUnavailableError)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<CcdBadge>(response, statusCodeToTypeMap);
            return new Response<CcdBadge>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get badges.
        /// </summary>
        /// <param name="request">Request object for ListBadges.</param>
        /// <param name="operationConfiguration">Configuration for ListBadges.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;CcdBadge&gt; object.</returns>
        /// <exception cref="Unity.Services.Ccd.Management.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<CcdBadge>>> ListBadgesAsync(Unity.Services.Ccd.Management.Badges.ListBadgesRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<CcdBadge>)   },{"400", typeof(Models.ValidationError)   },{"401", typeof(Models.AuthenticationError)   },{"403", typeof(Models.AuthorizationError)   },{"404", typeof(Models.NotFoundError)   },{"429", typeof(Models.TooManyRequestsError)   },{"500", typeof(Models.InternalServerError)   },{"503", typeof(Models.ServiceUnavailableError)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<CcdBadge>>(response, statusCodeToTypeMap);
            return new Response<List<CcdBadge>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Assign a badge.
        /// </summary>
        /// <param name="request">Request object for UpdateBadge.</param>
        /// <param name="operationConfiguration">Configuration for UpdateBadge.</param>
        /// <returns>Task for a Response object containing status code, headers, and CcdBadge object.</returns>
        /// <exception cref="Unity.Services.Ccd.Management.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<CcdBadge>> UpdateBadgeAsync(Unity.Services.Ccd.Management.Badges.UpdateBadgeRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(CcdBadge)   },{"400", typeof(Models.ValidationError)   },{"401", typeof(Models.AuthenticationError)   },{"403", typeof(Models.AuthorizationError)   },{"404", typeof(Models.NotFoundError)   },{"429", typeof(Models.TooManyRequestsError)   },{"500", typeof(Models.InternalServerError)   },{"503", typeof(Models.ServiceUnavailableError)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("PUT",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<CcdBadge>(response, statusCodeToTypeMap);
            return new Response<CcdBadge>(response, handledResponse);
        }

    }
}
