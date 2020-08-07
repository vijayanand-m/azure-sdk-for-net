// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class LanguageInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("text");
            writer.WriteStringValue(Text);
            if (Optional.IsDefined(CountryHint))
            {
                writer.WritePropertyName("countryHint");
                writer.WriteStringValue(CountryHint);
            }
            writer.WriteEndObject();
        }
    }
}