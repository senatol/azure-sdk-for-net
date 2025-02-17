// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class UploadCertificateResponse : IUtf8JsonSerializable, IJsonModel<UploadCertificateResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UploadCertificateResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UploadCertificateResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadCertificateResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UploadCertificateResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (AuthType.HasValue)
            {
                writer.WritePropertyName("authType"u8);
                writer.WriteStringValue(AuthType.Value.ToString());
            }
            if (options.Format != "W" && ResourceId != null)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (options.Format != "W" && AadAuthority != null)
            {
                writer.WritePropertyName("aadAuthority"u8);
                writer.WriteStringValue(AadAuthority);
            }
            if (options.Format != "W" && AadTenantId.HasValue)
            {
                writer.WritePropertyName("aadTenantId"u8);
                writer.WriteStringValue(AadTenantId.Value);
            }
            if (options.Format != "W" && ServicePrincipalClientId.HasValue)
            {
                writer.WritePropertyName("servicePrincipalClientId"u8);
                writer.WriteStringValue(ServicePrincipalClientId.Value);
            }
            if (options.Format != "W" && ServicePrincipalObjectId.HasValue)
            {
                writer.WritePropertyName("servicePrincipalObjectId"u8);
                writer.WriteStringValue(ServicePrincipalObjectId.Value);
            }
            if (options.Format != "W" && AzureManagementEndpointAudience != null)
            {
                writer.WritePropertyName("azureManagementEndpointAudience"u8);
                writer.WriteStringValue(AzureManagementEndpointAudience);
            }
            if (options.Format != "W" && AadAudience != null)
            {
                writer.WritePropertyName("aadAudience"u8);
                writer.WriteStringValue(AadAudience);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        UploadCertificateResponse IJsonModel<UploadCertificateResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadCertificateResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UploadCertificateResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUploadCertificateResponse(document.RootElement, options);
        }

        internal static UploadCertificateResponse DeserializeUploadCertificateResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxEdgeAuthenticationType? authType = default;
            string resourceId = default;
            string aadAuthority = default;
            Guid? aadTenantId = default;
            Guid? servicePrincipalClientId = default;
            Guid? servicePrincipalObjectId = default;
            string azureManagementEndpointAudience = default;
            string aadAudience = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authType = new DataBoxEdgeAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadAuthority"u8))
                {
                    aadAuthority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aadTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("servicePrincipalClientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePrincipalClientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("servicePrincipalObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePrincipalObjectId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("azureManagementEndpointAudience"u8))
                {
                    azureManagementEndpointAudience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadAudience"u8))
                {
                    aadAudience = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UploadCertificateResponse(
                authType,
                resourceId,
                aadAuthority,
                aadTenantId,
                servicePrincipalClientId,
                servicePrincipalObjectId,
                azureManagementEndpointAudience,
                aadAudience,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UploadCertificateResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadCertificateResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UploadCertificateResponse)} does not support '{options.Format}' format.");
            }
        }

        UploadCertificateResponse IPersistableModel<UploadCertificateResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadCertificateResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUploadCertificateResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UploadCertificateResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UploadCertificateResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
