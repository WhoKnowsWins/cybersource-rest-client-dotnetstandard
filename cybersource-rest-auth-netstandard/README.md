# .NET Standard Authentication SDK

This project provides a simple C# helper library that simplifies authentication to the CyberSource REST API.

## Requirements

* .NET Standard 2.1

* A CyberSource merchant account (see _Registration & Configuration_ section below)

## Dependencies

* jose-jwt 2.5.0              : Generating Json Web Token
* NLog 4.7.4                  : Logging

## Usage

The Authentication SDK works for `POST`, `GET`, `PUT` and `DELETE` requests.
It supports two authentication mechanisms, viz. HTTP Signature and JSON Web Token (JWT).

## Configuration

To set your API credentials for an API request, configure the following information in `App.Config` file inside the `<MerchantConfig></MerchantConfig>` tags:

### HTTP Signature Authentication

Configure the following information in `App.Config` file

* Authentication Type: Merchant should enter `"HTTP_Signature"` for HTTP authentication mechanism.

* Merchant ID: Merchant will provide the Merchant ID, which was received from EBC portal.

* MerchantSecretKey: Merchant will provide the Secret Key value, which was generated on EBC portal.

* MerchantKeyId: Merchant will provide the Key ID value, which was generated on EBC portal.

* Enable Log: To start the log entry, this value should be set to `true`, else `false`.

* LogDirectory: Merchant will provide directory path where logs will be created.

* LogMaximumSize: Merchant will provide size value for log file.

* LogFilename: Merchant will provide log file name.

```lang-none
   authenticationType  = http_Signature
   merchantID          = <merchantID>
   runEnvironment      = CyberSource.Environment.SANDBOX
   merchantKeyId       = <merchantKeyId>
   merchantsecretKey   = <merchantsecretKey>
   enableLog           = true
   logDirectory        = <logDirectory>
   logMaximumSize      = <size>
   logFilename         = <logFilename>
```

### JWT Authentication

Configure the following information in the `App.Config` file

* Authentication Type:  Merchant should enter `"JWT"` for JWT authentication mechanism.

* Merchant ID: Merchant will provide the Merchant ID, which was received from EBC portal.

* keyAlias: Alias of the Merchant ID, to be used while generating the JWT token.

* keyPassword: Alias of the Merchant password, to be used while generating the JWT token.

* keyfilepath: Path of the folder where the .P12 file is placed. This file can be generated from the EBC portal.

* Keys Directory: path of the directory, where keys are placed.

* Enable Log: To start the log entry, this value should be set to `true`, else `false`.

* LogDirectory: Merchant will provide directory path where logs will be created.

* LogMaximumSize: Merchant will provide size value for log file.

* LogFilename: Merchant will provide log file name.

```lang-none
   authenticationType  = Jwt
   merchantID          = <merchantID>
   runEnvironment      = CyberSource.Environment.SANDBOX
   keyAlias            = <keyAlias>
   keyPassword         = <keyPassword>
   keyFileName         = <keyFileName>
   keysDirectory       = <keysDirectory>
   enableLog           = true
   logDirectory        = <logDirectory>
   logMaximumSize      = <size>
   logFilename         = <logFilename>
```

### Switching between the sandbox environment and the production environment

CyberSource maintains a complete sandbox environment for testing and development purposes. This sandbox environment is an exact duplicate of our production environment with the transaction authorization and settlement process simulated. By default, this SDK is configured to communicate with the sandbox environment. To switch to the production environment, set the appropriate environment constant, as shown in [Sample Configuration file](https://github.com/CyberSource/cybersource-rest-samples-csharp/blob/master/Source/Configuration.cs).

For example:

```csharp
// For TESTING use
_configurationDictionary.Add("runEnvironment", "cybersource.environment.sandbox");

// For PRODUCTION use
// _configurationDictionary.Add("runEnvironment", "cybersource.environment.production");
```

## SDK Usage Examples and Sample Code

* To get started using this SDK, it is highly recommended to download our [sample code repository](https://github.com/CyberSource/cybersource-rest-samples-csharp).

* In that repository, we have comprehensive code samples for all common uses of our API.

* Additionally, you can find details and examples of how our API is structured in our [Developer Center API Reference](https://developer.cybersource.com/api/reference/api-reference.html).

The API Reference Guide provides examples of what information is needed for a particular request and how that information would be formatted. Using those examples, you can easily determine what methods would be necessary to include that information in a request using this SDK.

## License

This repository is distributed under a proprietary license.
