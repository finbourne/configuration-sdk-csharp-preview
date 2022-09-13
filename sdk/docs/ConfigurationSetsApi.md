# Finbourne.Configuration.Sdk.Api.ConfigurationSetsApi

All URIs are relative to *https://www.lusid.com/configuration*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddConfigurationToSet**](ConfigurationSetsApi.md#addconfigurationtoset) | **POST** /api/sets/{type}/{scope}/{code}/items | [EARLY ACCESS] AddConfigurationToSet: Add a configuration item to an existing set
[**CheckAccessTokenExists**](ConfigurationSetsApi.md#checkaccesstokenexists) | **HEAD** /api/sets/personal/me | [BETA] CheckAccessTokenExists: Check the Personal Access Token exists for the current user
[**CreateConfigurationSet**](ConfigurationSetsApi.md#createconfigurationset) | **POST** /api/sets | [EARLY ACCESS] CreateConfigurationSet: Create a configuration set
[**DeleteAccessToken**](ConfigurationSetsApi.md#deleteaccesstoken) | **DELETE** /api/sets/personal/me | [EARLY ACCESS] DeleteAccessToken: Delete any stored Personal Access Token for the current user
[**DeleteConfigurationItem**](ConfigurationSetsApi.md#deleteconfigurationitem) | **DELETE** /api/sets/{type}/{scope}/{code}/items/{key} | [EARLY ACCESS] DeleteConfigurationItem: Remove the specified configuration item from the specified configuration set
[**DeleteConfigurationSet**](ConfigurationSetsApi.md#deleteconfigurationset) | **DELETE** /api/sets/{type}/{scope}/{code} | [EARLY ACCESS] DeleteConfigurationSet: Deletes a configuration set along with all their configuration items
[**GenerateAccessToken**](ConfigurationSetsApi.md#generateaccesstoken) | **PUT** /api/sets/personal/me | [EARLY ACCESS] GenerateAccessToken: Generate a Personal Access Token for the current user and stores it in the me token
[**GetConfigurationItem**](ConfigurationSetsApi.md#getconfigurationitem) | **GET** /api/sets/{type}/{scope}/{code}/items/{key} | [EARLY ACCESS] GetConfigurationItem: Get the specific configuration item within an existing set
[**GetConfigurationSet**](ConfigurationSetsApi.md#getconfigurationset) | **GET** /api/sets/{type}/{scope}/{code} | [EARLY ACCESS] GetConfigurationSet: Get a configuration set, including all the associated metadata. By default secrets will not be revealed
[**GetSystemConfigurationItems**](ConfigurationSetsApi.md#getsystemconfigurationitems) | **GET** /api/sets/system/{code}/items/{key} | [EARLY ACCESS] GetSystemConfigurationItems: Get the specific system configuration items within a system set  All users have access to this endpoint
[**GetSystemConfigurationSets**](ConfigurationSetsApi.md#getsystemconfigurationsets) | **GET** /api/sets/system/{code} | [EARLY ACCESS] GetSystemConfigurationSets: Get the specified system configuration sets, including all their associated metadata. By default secrets will not be revealed  All users have access to this endpoint
[**ListConfigurationSets**](ConfigurationSetsApi.md#listconfigurationsets) | **GET** /api/sets | [EARLY ACCESS] ListConfigurationSets: List all configuration sets summaries (I.e. list of scope/code combinations available)
[**UpdateConfigurationItem**](ConfigurationSetsApi.md#updateconfigurationitem) | **PUT** /api/sets/{type}/{scope}/{code}/items/{key} | [EARLY ACCESS] UpdateConfigurationItem: Update a configuration item&#39;s value and/or description
[**UpdateConfigurationSet**](ConfigurationSetsApi.md#updateconfigurationset) | **PUT** /api/sets/{type}/{scope}/{code} | [EARLY ACCESS] UpdateConfigurationSet: Update the description of a configuration set


<a name="addconfigurationtoset"></a>
# **AddConfigurationToSet**
> ConfigurationSet AddConfigurationToSet (string type, string scope, string code, CreateConfigurationItem createConfigurationItem, string userId = null)

[EARLY ACCESS] AddConfigurationToSet: Add a configuration item to an existing set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class AddConfigurationToSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var type = type_example;  // string | Whether the configuration set is Personal or Shared
            var scope = scope_example;  // string | The scope that identifies a configuration set
            var code = code_example;  // string | The code that identifies a configuration set
            var createConfigurationItem = new CreateConfigurationItem(); // CreateConfigurationItem | The data to create a configuration item
            var userId = userId_example;  // string | Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. (optional) 

            try
            {
                // [EARLY ACCESS] AddConfigurationToSet: Add a configuration item to an existing set
                ConfigurationSet result = apiInstance.AddConfigurationToSet(type, scope, code, createConfigurationItem, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.AddConfigurationToSet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Whether the configuration set is Personal or Shared | 
 **scope** | **string**| The scope that identifies a configuration set | 
 **code** | **string**| The code that identifies a configuration set | 
 **createConfigurationItem** | [**CreateConfigurationItem**](CreateConfigurationItem.md)| The data to create a configuration item | 
 **userId** | **string**| Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. | [optional] 

### Return type

[**ConfigurationSet**](ConfigurationSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No configuration set exists with the provided identifiers |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkaccesstokenexists"></a>
# **CheckAccessTokenExists**
> void CheckAccessTokenExists ()

[BETA] CheckAccessTokenExists: Check the Personal Access Token exists for the current user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class CheckAccessTokenExistsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);

            try
            {
                // [BETA] CheckAccessTokenExists: Check the Personal Access Token exists for the current user
                apiInstance.CheckAccessTokenExists();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.CheckAccessTokenExists: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Personal Access Token exists |  -  |
| **404** | The Personal Access Token does not exist |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createconfigurationset"></a>
# **CreateConfigurationSet**
> ConfigurationSet CreateConfigurationSet (CreateConfigurationSet createConfigurationSet, string userId = null)

[EARLY ACCESS] CreateConfigurationSet: Create a configuration set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class CreateConfigurationSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var createConfigurationSet = new CreateConfigurationSet(); // CreateConfigurationSet | The data to create a configuration set
            var userId = userId_example;  // string | Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. (optional) 

            try
            {
                // [EARLY ACCESS] CreateConfigurationSet: Create a configuration set
                ConfigurationSet result = apiInstance.CreateConfigurationSet(createConfigurationSet, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.CreateConfigurationSet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createConfigurationSet** | [**CreateConfigurationSet**](CreateConfigurationSet.md)| The data to create a configuration set | 
 **userId** | **string**| Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. | [optional] 

### Return type

[**ConfigurationSet**](ConfigurationSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccesstoken"></a>
# **DeleteAccessToken**
> void DeleteAccessToken ()

[EARLY ACCESS] DeleteAccessToken: Delete any stored Personal Access Token for the current user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class DeleteAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);

            try
            {
                // [EARLY ACCESS] DeleteAccessToken: Delete any stored Personal Access Token for the current user
                apiInstance.DeleteAccessToken();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.DeleteAccessToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteconfigurationitem"></a>
# **DeleteConfigurationItem**
> void DeleteConfigurationItem (string type, string scope, string code, string key, string userId = null)

[EARLY ACCESS] DeleteConfigurationItem: Remove the specified configuration item from the specified configuration set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class DeleteConfigurationItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var type = type_example;  // string | Whether the configuration set is Personal or Shared
            var scope = scope_example;  // string | The scope that identifies a configuration set
            var code = code_example;  // string | The code that identifies a configuration set
            var key = key_example;  // string | The key that identifies a configuration item
            var userId = userId_example;  // string | Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. (optional) 

            try
            {
                // [EARLY ACCESS] DeleteConfigurationItem: Remove the specified configuration item from the specified configuration set
                apiInstance.DeleteConfigurationItem(type, scope, code, key, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.DeleteConfigurationItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Whether the configuration set is Personal or Shared | 
 **scope** | **string**| The scope that identifies a configuration set | 
 **code** | **string**| The code that identifies a configuration set | 
 **key** | **string**| The key that identifies a configuration item | 
 **userId** | **string**| Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No configuration item exists with the provided identifiers |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteconfigurationset"></a>
# **DeleteConfigurationSet**
> void DeleteConfigurationSet (string type, string scope, string code, string userId = null)

[EARLY ACCESS] DeleteConfigurationSet: Deletes a configuration set along with all their configuration items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class DeleteConfigurationSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var type = type_example;  // string | Whether the configuration set is Personal or Shared
            var scope = scope_example;  // string | The scope that identifies a configuration set
            var code = code_example;  // string | The code that identifies a configuration set
            var userId = userId_example;  // string | Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. (optional) 

            try
            {
                // [EARLY ACCESS] DeleteConfigurationSet: Deletes a configuration set along with all their configuration items
                apiInstance.DeleteConfigurationSet(type, scope, code, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.DeleteConfigurationSet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Whether the configuration set is Personal or Shared | 
 **scope** | **string**| The scope that identifies a configuration set | 
 **code** | **string**| The code that identifies a configuration set | 
 **userId** | **string**| Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No configuration set exists with the provided identifiers |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateaccesstoken"></a>
# **GenerateAccessToken**
> PersonalAccessToken GenerateAccessToken (string action = null)

[EARLY ACCESS] GenerateAccessToken: Generate a Personal Access Token for the current user and stores it in the me token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class GenerateAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var action = action_example;  // string | action=regenerate = Even if an existing parameter exists, forcibly regenerate a new one (deleting the old)  action=ensure = If no parameter exists, create one. If one does already exist, verify that it is still valid (call a service?), and if so, return it. If it is not still valid, then regenerate a new one.  action=default = If a parameter exists, return it. If not then create one. If this parameter is not provided, this is the default behaviour. (optional) 

            try
            {
                // [EARLY ACCESS] GenerateAccessToken: Generate a Personal Access Token for the current user and stores it in the me token
                PersonalAccessToken result = apiInstance.GenerateAccessToken(action);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.GenerateAccessToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **string**| action&#x3D;regenerate &#x3D; Even if an existing parameter exists, forcibly regenerate a new one (deleting the old)  action&#x3D;ensure &#x3D; If no parameter exists, create one. If one does already exist, verify that it is still valid (call a service?), and if so, return it. If it is not still valid, then regenerate a new one.  action&#x3D;default &#x3D; If a parameter exists, return it. If not then create one. If this parameter is not provided, this is the default behaviour. | [optional] 

### Return type

[**PersonalAccessToken**](PersonalAccessToken.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfigurationitem"></a>
# **GetConfigurationItem**
> ConfigurationItem GetConfigurationItem (string type, string scope, string code, string key, bool? reveal = null, string userId = null)

[EARLY ACCESS] GetConfigurationItem: Get the specific configuration item within an existing set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class GetConfigurationItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var type = type_example;  // string | Whether the configuration set is Personal or Shared
            var scope = scope_example;  // string | The scope that identifies a configuration set
            var code = code_example;  // string | The code that identifies a configuration set
            var key = key_example;  // string | The key that identifies a configuration item
            var reveal = true;  // bool? | Whether to reveal the secrets. This is only available when the userId query setting has not been specified. (optional) 
            var userId = userId_example;  // string | Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. (optional) 

            try
            {
                // [EARLY ACCESS] GetConfigurationItem: Get the specific configuration item within an existing set
                ConfigurationItem result = apiInstance.GetConfigurationItem(type, scope, code, key, reveal, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.GetConfigurationItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Whether the configuration set is Personal or Shared | 
 **scope** | **string**| The scope that identifies a configuration set | 
 **code** | **string**| The code that identifies a configuration set | 
 **key** | **string**| The key that identifies a configuration item | 
 **reveal** | **bool?**| Whether to reveal the secrets. This is only available when the userId query setting has not been specified. | [optional] 
 **userId** | **string**| Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. | [optional] 

### Return type

[**ConfigurationItem**](ConfigurationItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No configuration item exists with the provided identifiers |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfigurationset"></a>
# **GetConfigurationSet**
> ConfigurationSet GetConfigurationSet (string type, string scope, string code, bool? reveal = null, string userId = null)

[EARLY ACCESS] GetConfigurationSet: Get a configuration set, including all the associated metadata. By default secrets will not be revealed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class GetConfigurationSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var type = type_example;  // string | Whether the configuration set is Personal or Shared
            var scope = scope_example;  // string | The scope that identifies a configuration set
            var code = code_example;  // string | The code that identifies a configuration set
            var reveal = true;  // bool? | Whether to reveal the secrets. This is only available when the userId query setting has not been specified. (optional) 
            var userId = userId_example;  // string | Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. (optional) 

            try
            {
                // [EARLY ACCESS] GetConfigurationSet: Get a configuration set, including all the associated metadata. By default secrets will not be revealed
                ConfigurationSet result = apiInstance.GetConfigurationSet(type, scope, code, reveal, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.GetConfigurationSet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Whether the configuration set is Personal or Shared | 
 **scope** | **string**| The scope that identifies a configuration set | 
 **code** | **string**| The code that identifies a configuration set | 
 **reveal** | **bool?**| Whether to reveal the secrets. This is only available when the userId query setting has not been specified. | [optional] 
 **userId** | **string**| Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. | [optional] 

### Return type

[**ConfigurationSet**](ConfigurationSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No configuration set exists with the provided identifiers |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemconfigurationitems"></a>
# **GetSystemConfigurationItems**
> ResourceListOfConfigurationItem GetSystemConfigurationItems (string code, string key, bool? reveal = null)

[EARLY ACCESS] GetSystemConfigurationItems: Get the specific system configuration items within a system set  All users have access to this endpoint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class GetSystemConfigurationItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var code = code_example;  // string | The code that identifies a system configuration set
            var key = key_example;  // string | The key that identifies a system configuration item
            var reveal = true;  // bool? | Whether to reveal the secrets (optional) 

            try
            {
                // [EARLY ACCESS] GetSystemConfigurationItems: Get the specific system configuration items within a system set  All users have access to this endpoint
                ResourceListOfConfigurationItem result = apiInstance.GetSystemConfigurationItems(code, key, reveal);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.GetSystemConfigurationItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code that identifies a system configuration set | 
 **key** | **string**| The key that identifies a system configuration item | 
 **reveal** | **bool?**| Whether to reveal the secrets | [optional] 

### Return type

[**ResourceListOfConfigurationItem**](ResourceListOfConfigurationItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No system configuration item exists with the provided identifiers |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemconfigurationsets"></a>
# **GetSystemConfigurationSets**
> ResourceListOfConfigurationSet GetSystemConfigurationSets (string code, bool? reveal = null)

[EARLY ACCESS] GetSystemConfigurationSets: Get the specified system configuration sets, including all their associated metadata. By default secrets will not be revealed  All users have access to this endpoint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class GetSystemConfigurationSetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var code = code_example;  // string | The code that identifies a system configuration set
            var reveal = true;  // bool? | Whether to reveal the secrets (optional) 

            try
            {
                // [EARLY ACCESS] GetSystemConfigurationSets: Get the specified system configuration sets, including all their associated metadata. By default secrets will not be revealed  All users have access to this endpoint
                ResourceListOfConfigurationSet result = apiInstance.GetSystemConfigurationSets(code, reveal);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.GetSystemConfigurationSets: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code that identifies a system configuration set | 
 **reveal** | **bool?**| Whether to reveal the secrets | [optional] 

### Return type

[**ResourceListOfConfigurationSet**](ResourceListOfConfigurationSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No system configuration set exists with the provided identifiers |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listconfigurationsets"></a>
# **ListConfigurationSets**
> ResourceListOfConfigurationSetSummary ListConfigurationSets (string type = null, string userId = null)

[EARLY ACCESS] ListConfigurationSets: List all configuration sets summaries (I.e. list of scope/code combinations available)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class ListConfigurationSetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var type = type_example;  // string | Whether the configuration set is Personal or Shared (optional) 
            var userId = userId_example;  // string | Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. (optional) 

            try
            {
                // [EARLY ACCESS] ListConfigurationSets: List all configuration sets summaries (I.e. list of scope/code combinations available)
                ResourceListOfConfigurationSetSummary result = apiInstance.ListConfigurationSets(type, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.ListConfigurationSets: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Whether the configuration set is Personal or Shared | [optional] 
 **userId** | **string**| Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. | [optional] 

### Return type

[**ResourceListOfConfigurationSetSummary**](ResourceListOfConfigurationSetSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconfigurationitem"></a>
# **UpdateConfigurationItem**
> ConfigurationItem UpdateConfigurationItem (string type, string scope, string code, string key, UpdateConfigurationItem updateConfigurationItem, string userId = null)

[EARLY ACCESS] UpdateConfigurationItem: Update a configuration item's value and/or description

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class UpdateConfigurationItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var type = type_example;  // string | Whether the configuration set is Personal or Shared
            var scope = scope_example;  // string | The scope that identifies a configuration set
            var code = code_example;  // string | The code that identifies a configuration set
            var key = key_example;  // string | The key that identifies a configuration item
            var updateConfigurationItem = new UpdateConfigurationItem(); // UpdateConfigurationItem | The data to update a configuration item
            var userId = userId_example;  // string | Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. (optional) 

            try
            {
                // [EARLY ACCESS] UpdateConfigurationItem: Update a configuration item's value and/or description
                ConfigurationItem result = apiInstance.UpdateConfigurationItem(type, scope, code, key, updateConfigurationItem, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.UpdateConfigurationItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Whether the configuration set is Personal or Shared | 
 **scope** | **string**| The scope that identifies a configuration set | 
 **code** | **string**| The code that identifies a configuration set | 
 **key** | **string**| The key that identifies a configuration item | 
 **updateConfigurationItem** | [**UpdateConfigurationItem**](UpdateConfigurationItem.md)| The data to update a configuration item | 
 **userId** | **string**| Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. | [optional] 

### Return type

[**ConfigurationItem**](ConfigurationItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No configuration item exists with the provided identifiers |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconfigurationset"></a>
# **UpdateConfigurationSet**
> ConfigurationSet UpdateConfigurationSet (string type, string scope, string code, UpdateConfigurationSet updateConfigurationSet, string userId = null)

[EARLY ACCESS] UpdateConfigurationSet: Update the description of a configuration set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Configuration.Sdk.Api;
using Finbourne.Configuration.Sdk.Client;
using Finbourne.Configuration.Sdk.Model;

namespace Example
{
    public class UpdateConfigurationSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/configuration";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationSetsApi(config);
            var type = type_example;  // string | Whether the configuration set is Personal or Shared
            var scope = scope_example;  // string | The scope that identifies a configuration set
            var code = code_example;  // string | The code that identifies a configuration set
            var updateConfigurationSet = new UpdateConfigurationSet(); // UpdateConfigurationSet | The data to update a configuration set
            var userId = userId_example;  // string | Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. (optional) 

            try
            {
                // [EARLY ACCESS] UpdateConfigurationSet: Update the description of a configuration set
                ConfigurationSet result = apiInstance.UpdateConfigurationSet(type, scope, code, updateConfigurationSet, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationSetsApi.UpdateConfigurationSet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Whether the configuration set is Personal or Shared | 
 **scope** | **string**| The scope that identifies a configuration set | 
 **code** | **string**| The code that identifies a configuration set | 
 **updateConfigurationSet** | [**UpdateConfigurationSet**](UpdateConfigurationSet.md)| The data to update a configuration set | 
 **userId** | **string**| Feature that allows Administrators to administer personal settings  (but never reveal the value of secrets) of a specific user. | [optional] 

### Return type

[**ConfigurationSet**](ConfigurationSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No configuration set exists with the provided identifiers |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

