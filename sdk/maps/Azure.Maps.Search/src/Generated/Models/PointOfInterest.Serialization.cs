// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    public partial class PointOfInterest
    {
        internal static PointOfInterest DeserializePointOfInterest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string phone = default;
            string url = default;
            IReadOnlyList<PointOfInterestCategorySet> categorySet = default;
            IReadOnlyList<string> categories = default;
            IReadOnlyList<PointOfInterestClassification> classifications = default;
            IReadOnlyList<BrandName> brands = default;
            OperatingHours openingHours = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categorySet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PointOfInterestCategorySet> array = new List<PointOfInterestCategorySet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PointOfInterestCategorySet.DeserializePointOfInterestCategorySet(item));
                    }
                    categorySet = array;
                    continue;
                }
                if (property.NameEquals("categories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("classifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PointOfInterestClassification> array = new List<PointOfInterestClassification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PointOfInterestClassification.DeserializePointOfInterestClassification(item));
                    }
                    classifications = array;
                    continue;
                }
                if (property.NameEquals("brands"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BrandName> array = new List<BrandName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BrandName.DeserializeBrandName(item));
                    }
                    brands = array;
                    continue;
                }
                if (property.NameEquals("openingHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openingHours = OperatingHours.DeserializeOperatingHours(property.Value);
                    continue;
                }
            }
            return new PointOfInterest(
                name,
                phone,
                url,
                categorySet ?? new ChangeTrackingList<PointOfInterestCategorySet>(),
                categories ?? new ChangeTrackingList<string>(),
                classifications ?? new ChangeTrackingList<PointOfInterestClassification>(),
                brands ?? new ChangeTrackingList<BrandName>(),
                openingHours);
        }
    }
}
