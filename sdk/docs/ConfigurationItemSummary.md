# Finbourne.Configuration.Sdk.Model.ConfigurationItemSummary
A single configuration object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key which identifies the configuration item | 
**Value** | **string** | The value of the configuration item | 
**Type** | **string** | Defines how the value is presented.  If it is secret, the value will be hidden.  If it is text, the value will be in plain-text. | [readonly] 
**ValueType** | **string** | The type of the configuration item&#39;s value | 
**IsSecret** | **bool** | Defines whether or not the value is a secret.  This field will eventually replace the Type field of this class. | 
**Ref** | **string** | The reference to the configuration item | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

