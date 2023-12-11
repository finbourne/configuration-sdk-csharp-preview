# Deprecated

Please note that this repository is deprecated and will be archived early 2024.

All functionality is now contained, in the [configuration-sdk-csharp](https://github.com/finbourne/configuration-sdk-csharp) repository on the `main` branch.

# LUSID<sup>®</sup> Configuration SDK C# (Preview)
![LUSID by Finbourne](https://content.finbourne.com/LUSID_repo.png)

This is the C# SDK (Preview) for the Configuration Store application, part of the [LUSID by FINBOURNE](https://www.finbourne.com/lusid-technology) platform. To use it you'll need a LUSID account. [Sign up for free at lusid.com](https://www.lusid.com/app/signup).

The configuration store provides a secure central repository for secrets and parameters (like the AWS Parameter Store).

For more details on other applications in the LUSID platform, see [Understanding all the applications in the LUSID platform](https://support.lusid.com/knowledgebase/article/KA-01787/en-us).

[C# SDK Extensions](https://github.com/finbourne/configuration-sdk-extensions-csharp) to accompany this SDK are available. These provides the user with additional extensions to make it easy to configure and use the API endpoints.

## Installation

The NuGet package for the FINBOURNE Configuration service SDK (Preview) can installed from https://www.nuget.org/packages/Finbourne.Configuration.Sdk.Preview using the following:

```
$ dotnet add package Finbourne.Configuration.Sdk.Preview
```

This C# SDK (Preview) supports `Production`, `Early Access`, `Beta` and `Experimental` API endpoints. For more details on API endpoint categories, see [Documentation - Release Lifecycle](https://www.lusid.com/app/resources/documentation/lifecycle). To find out which category an API endpoint falls into, see [FINBOURNE Configuration API Documentation](https://www.lusid.com/configuration/swagger/index.html).

## Build Status 

![Nuget](https://img.shields.io/nuget/v/Finbourne.Configuration.Sdk.Preview?color=blue) [![Build](https://github.com/finbourne/configuration-sdk-csharp-preview/actions/workflows/build.yaml/badge.svg?branch=master)](https://github.com/finbourne/configuration-sdk-csharp-preview/actions/workflows/build.yaml)
