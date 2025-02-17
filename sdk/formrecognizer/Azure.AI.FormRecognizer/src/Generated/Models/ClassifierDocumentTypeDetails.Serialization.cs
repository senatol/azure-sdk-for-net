// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class ClassifierDocumentTypeDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (AzureBlobSource != null)
            {
                writer.WritePropertyName("azureBlobSource"u8);
                writer.WriteObjectValue(AzureBlobSource);
            }
            if (AzureBlobFileListSource != null)
            {
                writer.WritePropertyName("azureBlobFileListSource"u8);
                writer.WriteObjectValue(AzureBlobFileListSource);
            }
            writer.WriteEndObject();
        }

        internal static ClassifierDocumentTypeDetails DeserializeClassifierDocumentTypeDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BlobContentSource azureBlobSource = default;
            BlobFileListContentSource azureBlobFileListSource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureBlobSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobSource = BlobContentSource.DeserializeBlobContentSource(property.Value);
                    continue;
                }
                if (property.NameEquals("azureBlobFileListSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobFileListSource = BlobFileListContentSource.DeserializeBlobFileListContentSource(property.Value);
                    continue;
                }
            }
            return new ClassifierDocumentTypeDetails(azureBlobSource, azureBlobFileListSource);
        }
    }
}
