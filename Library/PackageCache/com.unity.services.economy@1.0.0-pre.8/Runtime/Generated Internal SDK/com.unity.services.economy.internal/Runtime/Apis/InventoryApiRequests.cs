//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using UnityEngine.Networking;
using Unity.Services.Economy.Internal.Models;
using Unity.Services.Authentication.Internal;

namespace Unity.Services.Economy.Internal.Inventory
{
    internal static class JsonSerialization
    {
        public static byte[] Serialize<T>(T obj)
        {
            return Encoding.UTF8.GetBytes(SerializeToString(obj));
        }

        public static string SerializeToString<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }

    /// <summary>
    /// InventoryApiBaseRequest class
    /// </summary>
    [Preserve]
    internal class InventoryApiBaseRequest
    {
        /// <summary>
        /// Helper function to add a provided key and value to the provided
        /// query params and to escape the values correctly if it is a URL.
        /// </summary>
        /// <param name="queryParams">A `List/<string/>` of the query parameters.</param>
        /// <param name="key">The key to be added.</param>
        /// <param name="value">The value to be added.</param>
        /// <returns>Returns a `List/<string/>` with the `key` and `value` added to the provided `queryParams`.</returns>
        [Preserve]
        public List<string> AddParamsToQueryParams(List<string> queryParams, string key, string value)
        {
            key = UnityWebRequest.EscapeURL(key);
            value = UnityWebRequest.EscapeURL(value);
            queryParams.Add($"{key}={value}");

            return queryParams;
        }

        /// <summary>
        /// Helper function to add a provided key and list of values to the
        /// provided query params and to escape the values correctly if it is a
        /// URL.
        /// </summary>
        /// <param name="queryParams">A `List/<string/>` of the query parameters.</param>
        /// <param name="key">The key to be added.</param>
        /// <param name="values">List of values to be added.</param>
        /// <param name="style">string for defining the style, currently unused.</param>
        /// <param name="explode">True if query params should be escaped and added separately.</param>
        /// <returns>Returns a `List/<string/>`</returns>
        [Preserve]
        public List<string> AddParamsToQueryParams(List<string> queryParams, string key, List<string> values, string style, bool explode)
        {
            if (explode)
            {
                foreach(var value in values)
                {
                    string escapedValue = UnityWebRequest.EscapeURL(value);
                    queryParams.Add($"{UnityWebRequest.EscapeURL(key)}={escapedValue}");
                }
            }
            else
            {
                string paramString = $"{UnityWebRequest.EscapeURL(key)}=";
                foreach(var value in values)
                {
                    paramString += UnityWebRequest.EscapeURL(value) + ",";
                }
                paramString = paramString.Remove(paramString.Length - 1);
                queryParams.Add(paramString);
            }

            return queryParams;
        }

        /// <summary>
        /// Helper function to add a provided key and value to the provided
        /// query params and to escape the values correctly if it is a URL.
        /// </summary>
        /// <param name="queryParams">A `List/<string/>` of the query parameters.</param>
        /// <param name="key">The key to be added.</param>
        /// <typeparam name="T">The type of the value to be added.</typeparam>
        /// <param name="value">The value to be added.</param>
        /// <returns>Returns a `List/<string/>`</returns>
        [Preserve]
        public List<string> AddParamsToQueryParams<T>(List<string> queryParams, string key, T value)
        {
            if (queryParams == null)
            {
                queryParams = new List<string>();
            }

            key = UnityWebRequest.EscapeURL(key);
            string valueString = UnityWebRequest.EscapeURL(value.ToString());
            queryParams.Add($"{key}={valueString}");
            return queryParams;
        }

        /// <summary>
        /// Constructs a string representing an array path parameter.
        /// </summary>
        /// <param name="pathParam">The list of values to convert to string.</param>
        /// <returns>String representing the param.</returns>
        [Preserve]
        public string GetPathParamString(List<string> pathParam)
        {
            string paramString = "";
            foreach(var value in pathParam)
            {
                paramString += UnityWebRequest.EscapeURL(value) + ",";
            }
            paramString = paramString.Remove(paramString.Length - 1);
            return paramString;
        }

        /// <summary>
        /// Constructs the body of the request based on IO stream.
        /// </summary>
        /// <param name="stream">The IO stream to use.</param>
        /// <returns>Byte array representing the body.</returns>
        public byte[] ConstructBody(System.IO.Stream stream)
        {
            if (stream != null)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
            return null;
        }

        /// <summary>
        /// Construct the request body based on string value.
        /// </summary>
        /// <param name="s">The input body.</param>
        /// <returns>Byte array representing the body.</returns>
        public byte[] ConstructBody(string s)
        {
            return System.Text.Encoding.UTF8.GetBytes(s);
        }

        /// <summary>
        /// Construct request body based on generic object.
        /// </summary>
        /// <param name="o">The object to use.</param>
        /// <returns>Byte array representing the body.</returns>
        public byte[] ConstructBody(object o)
        {
            return JsonSerialization.Serialize(o);
        }

        /// <summary>
        /// Generate an accept header.
        /// </summary>
        /// <param name="accepts">list of accepts objects.</param>
        /// <returns>The generated accept header.</returns>
        public string GenerateAcceptHeader(string[] accepts)
        {
            if (accepts.Length == 0)
            {
                return null;
            }
            for (int i = 0; i < accepts.Length; ++i)
            {
                if (string.Equals(accepts[i], "application/json", System.StringComparison.OrdinalIgnoreCase))
                {
                    return "application/json";
                }
            }
            return string.Join(", ", accepts);
        }

        private static readonly Regex JsonRegex = new Regex(@"application\/json(;\s)?((charset=utf8|q=[0-1]\.\d)(\s)?)*");

        /// <summary>
        /// Generate Content Type Header.
        /// </summary>
        /// <param name="contentTypes">The content types.</param>
        /// <returns>The Content Type Header.</returns>
        public string GenerateContentTypeHeader(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
            {
                return null;
            }

            for(int i = 0; i < contentTypes.Length; ++i)
            {
                if (!string.IsNullOrWhiteSpace(contentTypes[i]) && JsonRegex.IsMatch(contentTypes[i]))
                {
                    return contentTypes[i];
                }
            }
            return contentTypes[0];
        }

        /// <summary>
        /// Generate multipart form file section.
        /// </summary>
        /// <param name="paramName">The parameter name.</param>
        /// <param name="stream">The IO stream to use.</param>
        /// <param name="contentType">The content type.</param>
        /// <returns>Returns a multipart form section.</returns>
        public IMultipartFormSection GenerateMultipartFormFileSection(string paramName, System.IO.Stream stream, string contentType)
        {
            if (stream is System.IO.FileStream)
            {
                System.IO.FileStream fileStream = (System.IO.FileStream) stream;
                return new MultipartFormFileSection(paramName, ConstructBody(fileStream), GetFileName(fileStream.Name), contentType);
            }
            return new MultipartFormDataSection(paramName, ConstructBody(stream));
        }

        private string GetFileName(string filePath)
        {
            return System.IO.Path.GetFileName(filePath);
        }
    }

    /// <summary>
    /// AddInventoryItemRequest
    /// Add Inventory Item
    /// </summary>
    [Preserve]
    internal class AddInventoryItemRequest : InventoryApiBaseRequest
    {
        /// <summary>Accessor for projectId </summary>
        [Preserve]
        
        public string ProjectId { get; }
        /// <summary>Accessor for playerId </summary>
        [Preserve]
        
        public string PlayerId { get; }
        /// <summary>Accessor for bundleId </summary>
        [Preserve]
        public string BundleId { get; }
        
        /// <summary>Accessor for addInventoryRequest </summary>
        [Preserve]
        public AddInventoryRequest AddInventoryRequest { get; }
        
        string PathAndQueryParams;

        /// <summary>
        /// AddInventoryItem Request Object.
        /// Add Inventory Item
        /// </summary>
        /// <param name="projectId">ID of the project</param>
        /// <param name="playerId">ID of the player</param>
        /// <param name="bundleId">ID of the Remote Config bundle</param>
        /// <param name="addInventoryRequest">AddInventoryRequest param</param>
        [Preserve]
        public AddInventoryItemRequest(string projectId, string playerId, string bundleId = default(string), AddInventoryRequest addInventoryRequest = default(AddInventoryRequest))
        {
            
            ProjectId = projectId;
            
            PlayerId = playerId;
            BundleId = bundleId;
                        AddInventoryRequest = addInventoryRequest;
            

            PathAndQueryParams = $"/v2/projects/{projectId}/players/{playerId}/inventory";

            List<string> queryParams = new List<string>();

            if(!string.IsNullOrEmpty(BundleId))
            {
                queryParams = AddParamsToQueryParams(queryParams, "bundleId", BundleId);
            }
            if (queryParams.Count > 0)
            {
                PathAndQueryParams = $"{PathAndQueryParams}?{string.Join("&", queryParams)}";
            }
        }

        /// <summary>
        /// Helper function for constructing URL from request base path and
        /// query params.
        /// </summary>
        /// <param name="requestBasePath"></param>
        /// <returns></returns>
        public string ConstructUrl(string requestBasePath)
        {
            return requestBasePath + PathAndQueryParams;
        }

        /// <summary>
        /// Helper for constructing the request body.
        /// </summary>
        /// <returns>A list of IMultipartFormSection representing the request body.</returns>
        public byte[] ConstructBody()
        {
            if(AddInventoryRequest != null)
            {
                return ConstructBody(AddInventoryRequest);
            }
            return null;
        }

        /// <summary>
        /// Helper function for constructing the headers.
        /// </summary>
        /// <param name="accessToken">The auth access token to use.</param>
        /// <param name="operationConfiguration">The operation configuration to use.</param>
        /// <returns>A dictionary representing the request headers.</returns>
        public Dictionary<string, string> ConstructHeaders(IAccessToken accessToken,
            Configuration operationConfiguration = null)
        {
            var headers = new Dictionary<string, string>();
            if(!string.IsNullOrEmpty(accessToken.AccessToken))
            {
                headers.Add("authorization", "Bearer " + accessToken.AccessToken);
            }

            string[] contentTypes = {
                "application/json"
            };

            string[] accepts = {
                "application/json",
                "application/problem+json"
            };

            var acceptHeader = GenerateAcceptHeader(accepts);
            if (!string.IsNullOrEmpty(acceptHeader))
            {
                headers.Add("Accept", acceptHeader);
            }
            var httpMethod = "POST";
            var contentTypeHeader = GenerateContentTypeHeader(contentTypes);
            if (!string.IsNullOrEmpty(contentTypeHeader))
            {
                headers.Add("Content-Type", contentTypeHeader);
            }
            else if (httpMethod == "POST" || httpMethod == "PATCH")
            {
                headers.Add("Content-Type", "application/json");
            }


            // We also check if there are headers that are defined as part of
            // the request configuration.
            if (operationConfiguration != null && operationConfiguration.Headers != null)
            {
                foreach (var pair in operationConfiguration.Headers)
                {
                    headers[pair.Key] = pair.Value;
                }
            }

            return headers;
        }
    }
    /// <summary>
    /// DeleteInventoryItemRequest
    /// Delete Inventory Item
    /// </summary>
    [Preserve]
    internal class DeleteInventoryItemRequest : InventoryApiBaseRequest
    {
        /// <summary>Accessor for projectId </summary>
        [Preserve]
        
        public string ProjectId { get; }
        /// <summary>Accessor for playerId </summary>
        [Preserve]
        
        public string PlayerId { get; }
        /// <summary>Accessor for playersInventoryItemId </summary>
        [Preserve]
        
        public string PlayersInventoryItemId { get; }
        /// <summary>Accessor for bundleId </summary>
        [Preserve]
        public string BundleId { get; }
        
        /// <summary>Accessor for inventoryDeleteRequest </summary>
        [Preserve]
        public InventoryDeleteRequest InventoryDeleteRequest { get; }
        
        string PathAndQueryParams;

        /// <summary>
        /// DeleteInventoryItem Request Object.
        /// Delete Inventory Item
        /// </summary>
        /// <param name="projectId">projectId param</param>
        /// <param name="playerId">playerId param</param>
        /// <param name="playersInventoryItemId">playersInventoryItemId param</param>
        /// <param name="bundleId">ID of the Remote Config bundle</param>
        /// <param name="inventoryDeleteRequest">InventoryDeleteRequest param</param>
        [Preserve]
        public DeleteInventoryItemRequest(string projectId, string playerId, string playersInventoryItemId, string bundleId = default(string), InventoryDeleteRequest inventoryDeleteRequest = default(InventoryDeleteRequest))
        {
            
            ProjectId = projectId;
            
            PlayerId = playerId;
            
            PlayersInventoryItemId = playersInventoryItemId;
            BundleId = bundleId;
                        InventoryDeleteRequest = inventoryDeleteRequest;
            

            PathAndQueryParams = $"/v2/projects/{projectId}/players/{playerId}/inventory/{playersInventoryItemId}";

            List<string> queryParams = new List<string>();

            if(!string.IsNullOrEmpty(BundleId))
            {
                queryParams = AddParamsToQueryParams(queryParams, "bundleId", BundleId);
            }
            if (queryParams.Count > 0)
            {
                PathAndQueryParams = $"{PathAndQueryParams}?{string.Join("&", queryParams)}";
            }
        }

        /// <summary>
        /// Helper function for constructing URL from request base path and
        /// query params.
        /// </summary>
        /// <param name="requestBasePath"></param>
        /// <returns></returns>
        public string ConstructUrl(string requestBasePath)
        {
            return requestBasePath + PathAndQueryParams;
        }

        /// <summary>
        /// Helper for constructing the request body.
        /// </summary>
        /// <returns>A list of IMultipartFormSection representing the request body.</returns>
        public byte[] ConstructBody()
        {
            if(InventoryDeleteRequest != null)
            {
                return ConstructBody(InventoryDeleteRequest);
            }
            return null;
        }

        /// <summary>
        /// Helper function for constructing the headers.
        /// </summary>
        /// <param name="accessToken">The auth access token to use.</param>
        /// <param name="operationConfiguration">The operation configuration to use.</param>
        /// <returns>A dictionary representing the request headers.</returns>
        public Dictionary<string, string> ConstructHeaders(IAccessToken accessToken,
            Configuration operationConfiguration = null)
        {
            var headers = new Dictionary<string, string>();
            if(!string.IsNullOrEmpty(accessToken.AccessToken))
            {
                headers.Add("authorization", "Bearer " + accessToken.AccessToken);
            }

            string[] contentTypes = {
                "application/json"
            };

            string[] accepts = {
                "application/problem+json"
            };

            var acceptHeader = GenerateAcceptHeader(accepts);
            if (!string.IsNullOrEmpty(acceptHeader))
            {
                headers.Add("Accept", acceptHeader);
            }
            var httpMethod = "DELETE";
            var contentTypeHeader = GenerateContentTypeHeader(contentTypes);
            if (!string.IsNullOrEmpty(contentTypeHeader))
            {
                headers.Add("Content-Type", contentTypeHeader);
            }
            else if (httpMethod == "POST" || httpMethod == "PATCH")
            {
                headers.Add("Content-Type", "application/json");
            }


            // We also check if there are headers that are defined as part of
            // the request configuration.
            if (operationConfiguration != null && operationConfiguration.Headers != null)
            {
                foreach (var pair in operationConfiguration.Headers)
                {
                    headers[pair.Key] = pair.Value;
                }
            }

            return headers;
        }
    }
    /// <summary>
    /// GetPlayerInventoryRequest
    /// List Player Inventory
    /// </summary>
    [Preserve]
    internal class GetPlayerInventoryRequest : InventoryApiBaseRequest
    {
        /// <summary>Accessor for projectId </summary>
        [Preserve]
        
        public string ProjectId { get; }
        /// <summary>Accessor for playerId </summary>
        [Preserve]
        
        public string PlayerId { get; }
        /// <summary>Accessor for bundleId </summary>
        [Preserve]
        public string BundleId { get; }
        
        /// <summary>Accessor for after </summary>
        [Preserve]
        public string After { get; }
        
        /// <summary>Accessor for limit </summary>
        [Preserve]
        public int Limit { get; }
        
        /// <summary>Accessor for playersInventoryItemIds </summary>
        [Preserve]
        public List<string> PlayersInventoryItemIds { get; }
        
        /// <summary>Accessor for inventoryItemIds </summary>
        [Preserve]
        public List<string> InventoryItemIds { get; }
        
        string PathAndQueryParams;

        /// <summary>
        /// GetPlayerInventory Request Object.
        /// List Player Inventory
        /// </summary>
        /// <param name="projectId">ID of the project</param>
        /// <param name="playerId">ID of the player</param>
        /// <param name="bundleId">ID of the Remote Config bundle</param>
        /// <param name="after">The Players inventory item ID after which to retrieve the next page of balances.</param>
        /// <param name="limit">Number of items to be returned. Defaults to 20.</param>
        /// <param name="playersInventoryItemIds">List of Players inventory item IDs in array notation, e.g. `playersInventoryItemIds[]=ID1&playersInventoryItemIds[]=ID2`</param>
        /// <param name="inventoryItemIds">List of Inventory IDs in array notation, e.g. `inventoryItemIds[]=ID1&inventoryItemIds[]=ID2`</param>
        [Preserve]
        public GetPlayerInventoryRequest(string projectId, string playerId, string bundleId = default(string), string after = default(string), int limit = default(int), List<string> playersInventoryItemIds = default(List<string>), List<string> inventoryItemIds = default(List<string>))
        {
            
            ProjectId = projectId;
            
            PlayerId = playerId;
            BundleId = bundleId;
                        After = after;
                        Limit = limit;
                        PlayersInventoryItemIds = playersInventoryItemIds;
                        InventoryItemIds = inventoryItemIds;
            

            PathAndQueryParams = $"/v2/projects/{projectId}/players/{playerId}/inventory";

            List<string> queryParams = new List<string>();

            if(!string.IsNullOrEmpty(BundleId))
            {
                queryParams = AddParamsToQueryParams(queryParams, "bundleId", BundleId);
            }
            if(!string.IsNullOrEmpty(After))
            {
                queryParams = AddParamsToQueryParams(queryParams, "after", After);
            }
            var limitStringValue = Limit.ToString();
            queryParams = AddParamsToQueryParams(queryParams, "limit", limitStringValue);
            if(PlayersInventoryItemIds != null)
            {
                var playersInventoryItemIdsStringValues = PlayersInventoryItemIds.Select(v => v.ToString()).ToList();
                queryParams = AddParamsToQueryParams(queryParams, "playersInventoryItemIds", playersInventoryItemIdsStringValues, "form", true);
            }
            if(InventoryItemIds != null)
            {
                var inventoryItemIdsStringValues = InventoryItemIds.Select(v => v.ToString()).ToList();
                queryParams = AddParamsToQueryParams(queryParams, "inventoryItemIds", inventoryItemIdsStringValues, "form", true);
            }
            if (queryParams.Count > 0)
            {
                PathAndQueryParams = $"{PathAndQueryParams}?{string.Join("&", queryParams)}";
            }
        }

        /// <summary>
        /// Helper function for constructing URL from request base path and
        /// query params.
        /// </summary>
        /// <param name="requestBasePath"></param>
        /// <returns></returns>
        public string ConstructUrl(string requestBasePath)
        {
            return requestBasePath + PathAndQueryParams;
        }

        /// <summary>
        /// Helper for constructing the request body.
        /// </summary>
        /// <returns>A list of IMultipartFormSection representing the request body.</returns>
        public byte[] ConstructBody()
        {
            return null;
        }

        /// <summary>
        /// Helper function for constructing the headers.
        /// </summary>
        /// <param name="accessToken">The auth access token to use.</param>
        /// <param name="operationConfiguration">The operation configuration to use.</param>
        /// <returns>A dictionary representing the request headers.</returns>
        public Dictionary<string, string> ConstructHeaders(IAccessToken accessToken,
            Configuration operationConfiguration = null)
        {
            var headers = new Dictionary<string, string>();
            if(!string.IsNullOrEmpty(accessToken.AccessToken))
            {
                headers.Add("authorization", "Bearer " + accessToken.AccessToken);
            }

            string[] contentTypes = {
            };

            string[] accepts = {
                "application/json",
                "application/problem+json"
            };

            var acceptHeader = GenerateAcceptHeader(accepts);
            if (!string.IsNullOrEmpty(acceptHeader))
            {
                headers.Add("Accept", acceptHeader);
            }
            var httpMethod = "GET";
            var contentTypeHeader = GenerateContentTypeHeader(contentTypes);
            if (!string.IsNullOrEmpty(contentTypeHeader))
            {
                headers.Add("Content-Type", contentTypeHeader);
            }
            else if (httpMethod == "POST" || httpMethod == "PATCH")
            {
                headers.Add("Content-Type", "application/json");
            }


            // We also check if there are headers that are defined as part of
            // the request configuration.
            if (operationConfiguration != null && operationConfiguration.Headers != null)
            {
                foreach (var pair in operationConfiguration.Headers)
                {
                    headers[pair.Key] = pair.Value;
                }
            }

            return headers;
        }
    }
    /// <summary>
    /// UpdateInventoryItemRequest
    /// Player Inventory Item
    /// </summary>
    [Preserve]
    internal class UpdateInventoryItemRequest : InventoryApiBaseRequest
    {
        /// <summary>Accessor for projectId </summary>
        [Preserve]
        
        public string ProjectId { get; }
        /// <summary>Accessor for playerId </summary>
        [Preserve]
        
        public string PlayerId { get; }
        /// <summary>Accessor for playersInventoryItemId </summary>
        [Preserve]
        
        public string PlayersInventoryItemId { get; }
        /// <summary>Accessor for bundleId </summary>
        [Preserve]
        public string BundleId { get; }
        
        /// <summary>Accessor for inventoryRequestUpdate </summary>
        [Preserve]
        public InventoryRequestUpdate InventoryRequestUpdate { get; }
        
        string PathAndQueryParams;

        /// <summary>
        /// UpdateInventoryItem Request Object.
        /// Player Inventory Item
        /// </summary>
        /// <param name="projectId">projectId param</param>
        /// <param name="playerId">playerId param</param>
        /// <param name="playersInventoryItemId">playersInventoryItemId param</param>
        /// <param name="bundleId">ID of the Remote Config bundle</param>
        /// <param name="inventoryRequestUpdate">InventoryRequestUpdate param</param>
        [Preserve]
        public UpdateInventoryItemRequest(string projectId, string playerId, string playersInventoryItemId, string bundleId = default(string), InventoryRequestUpdate inventoryRequestUpdate = default(InventoryRequestUpdate))
        {
            
            ProjectId = projectId;
            
            PlayerId = playerId;
            
            PlayersInventoryItemId = playersInventoryItemId;
            BundleId = bundleId;
                        InventoryRequestUpdate = inventoryRequestUpdate;
            

            PathAndQueryParams = $"/v2/projects/{projectId}/players/{playerId}/inventory/{playersInventoryItemId}";

            List<string> queryParams = new List<string>();

            if(!string.IsNullOrEmpty(BundleId))
            {
                queryParams = AddParamsToQueryParams(queryParams, "bundleId", BundleId);
            }
            if (queryParams.Count > 0)
            {
                PathAndQueryParams = $"{PathAndQueryParams}?{string.Join("&", queryParams)}";
            }
        }

        /// <summary>
        /// Helper function for constructing URL from request base path and
        /// query params.
        /// </summary>
        /// <param name="requestBasePath"></param>
        /// <returns></returns>
        public string ConstructUrl(string requestBasePath)
        {
            return requestBasePath + PathAndQueryParams;
        }

        /// <summary>
        /// Helper for constructing the request body.
        /// </summary>
        /// <returns>A list of IMultipartFormSection representing the request body.</returns>
        public byte[] ConstructBody()
        {
            if(InventoryRequestUpdate != null)
            {
                return ConstructBody(InventoryRequestUpdate);
            }
            return null;
        }

        /// <summary>
        /// Helper function for constructing the headers.
        /// </summary>
        /// <param name="accessToken">The auth access token to use.</param>
        /// <param name="operationConfiguration">The operation configuration to use.</param>
        /// <returns>A dictionary representing the request headers.</returns>
        public Dictionary<string, string> ConstructHeaders(IAccessToken accessToken,
            Configuration operationConfiguration = null)
        {
            var headers = new Dictionary<string, string>();
            if(!string.IsNullOrEmpty(accessToken.AccessToken))
            {
                headers.Add("authorization", "Bearer " + accessToken.AccessToken);
            }

            string[] contentTypes = {
                "application/json"
            };

            string[] accepts = {
                "application/json",
                "application/problem+json"
            };

            var acceptHeader = GenerateAcceptHeader(accepts);
            if (!string.IsNullOrEmpty(acceptHeader))
            {
                headers.Add("Accept", acceptHeader);
            }
            var httpMethod = "PUT";
            var contentTypeHeader = GenerateContentTypeHeader(contentTypes);
            if (!string.IsNullOrEmpty(contentTypeHeader))
            {
                headers.Add("Content-Type", contentTypeHeader);
            }
            else if (httpMethod == "POST" || httpMethod == "PATCH")
            {
                headers.Add("Content-Type", "application/json");
            }


            // We also check if there are headers that are defined as part of
            // the request configuration.
            if (operationConfiguration != null && operationConfiguration.Headers != null)
            {
                foreach (var pair in operationConfiguration.Headers)
                {
                    headers[pair.Key] = pair.Value;
                }
            }

            return headers;
        }
    }
}
