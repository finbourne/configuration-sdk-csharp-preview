# Finbourne.Configuration.Sdk.Model.CreateConfigurationItem
The information required to create a configuration item

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the new configuration item | 
**Value** | **string** | The value of the new configuration item                The maximum size for secrets is 4KB and for text values is 2MB | 
**ValueType** | **string** | The type of the new configuration item&#39;s value | [optional] 
**Type** | **string** | The type (text or secret) of the new configuration item | [optional] 
**IsSecret** | **bool?** | Defines whether or not the value is a secret.  This field will eventually replace the Type field of this class. | [optional] 
**Description** | **string** | The description of the new configuration item | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

