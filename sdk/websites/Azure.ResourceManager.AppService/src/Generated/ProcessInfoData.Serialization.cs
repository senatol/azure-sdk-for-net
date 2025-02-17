// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class ProcessInfoData : IUtf8JsonSerializable, IJsonModel<ProcessInfoData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProcessInfoData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProcessInfoData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProcessInfoData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Identifier.HasValue)
            {
                writer.WritePropertyName("identifier"u8);
                writer.WriteNumberValue(Identifier.Value);
            }
            if (DeploymentName != null)
            {
                writer.WritePropertyName("deployment_name"u8);
                writer.WriteStringValue(DeploymentName);
            }
            if (Href != null)
            {
                writer.WritePropertyName("href"u8);
                writer.WriteStringValue(Href);
            }
            if (Minidump != null)
            {
                writer.WritePropertyName("minidump"u8);
                writer.WriteStringValue(Minidump);
            }
            if (IsProfileRunning.HasValue)
            {
                writer.WritePropertyName("is_profile_running"u8);
                writer.WriteBooleanValue(IsProfileRunning.Value);
            }
            if (IsIisProfileRunning.HasValue)
            {
                writer.WritePropertyName("is_iis_profile_running"u8);
                writer.WriteBooleanValue(IsIisProfileRunning.Value);
            }
            if (IisProfileTimeoutInSeconds.HasValue)
            {
                writer.WritePropertyName("iis_profile_timeout_in_seconds"u8);
                writer.WriteNumberValue(IisProfileTimeoutInSeconds.Value);
            }
            if (Parent != null)
            {
                writer.WritePropertyName("parent"u8);
                writer.WriteStringValue(Parent);
            }
            if (!(Children is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("children"u8);
                writer.WriteStartArray();
                foreach (var item in Children)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Threads is ChangeTrackingList<ProcessThreadInfo> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("threads"u8);
                writer.WriteStartArray();
                foreach (var item in Threads)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(OpenFileHandles is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("open_file_handles"u8);
                writer.WriteStartArray();
                foreach (var item in OpenFileHandles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Modules is ChangeTrackingList<ProcessModuleInfoData> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("modules"u8);
                writer.WriteStartArray();
                foreach (var item in Modules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (FileName != null)
            {
                writer.WritePropertyName("file_name"u8);
                writer.WriteStringValue(FileName);
            }
            if (CommandLine != null)
            {
                writer.WritePropertyName("command_line"u8);
                writer.WriteStringValue(CommandLine);
            }
            if (UserName != null)
            {
                writer.WritePropertyName("user_name"u8);
                writer.WriteStringValue(UserName);
            }
            if (HandleCount.HasValue)
            {
                writer.WritePropertyName("handle_count"u8);
                writer.WriteNumberValue(HandleCount.Value);
            }
            if (ModuleCount.HasValue)
            {
                writer.WritePropertyName("module_count"u8);
                writer.WriteNumberValue(ModuleCount.Value);
            }
            if (ThreadCount.HasValue)
            {
                writer.WritePropertyName("thread_count"u8);
                writer.WriteNumberValue(ThreadCount.Value);
            }
            if (StartOn.HasValue)
            {
                writer.WritePropertyName("start_time"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (TotalCpuTime != null)
            {
                writer.WritePropertyName("total_cpu_time"u8);
                writer.WriteStringValue(TotalCpuTime);
            }
            if (UserCpuTime != null)
            {
                writer.WritePropertyName("user_cpu_time"u8);
                writer.WriteStringValue(UserCpuTime);
            }
            if (PrivilegedCpuTime != null)
            {
                writer.WritePropertyName("privileged_cpu_time"u8);
                writer.WriteStringValue(PrivilegedCpuTime);
            }
            if (WorkingSet.HasValue)
            {
                writer.WritePropertyName("working_set"u8);
                writer.WriteNumberValue(WorkingSet.Value);
            }
            if (PeakWorkingSet.HasValue)
            {
                writer.WritePropertyName("peak_working_set"u8);
                writer.WriteNumberValue(PeakWorkingSet.Value);
            }
            if (PrivateMemory.HasValue)
            {
                writer.WritePropertyName("private_memory"u8);
                writer.WriteNumberValue(PrivateMemory.Value);
            }
            if (VirtualMemory.HasValue)
            {
                writer.WritePropertyName("virtual_memory"u8);
                writer.WriteNumberValue(VirtualMemory.Value);
            }
            if (PeakVirtualMemory.HasValue)
            {
                writer.WritePropertyName("peak_virtual_memory"u8);
                writer.WriteNumberValue(PeakVirtualMemory.Value);
            }
            if (PagedSystemMemory.HasValue)
            {
                writer.WritePropertyName("paged_system_memory"u8);
                writer.WriteNumberValue(PagedSystemMemory.Value);
            }
            if (NonPagedSystemMemory.HasValue)
            {
                writer.WritePropertyName("non_paged_system_memory"u8);
                writer.WriteNumberValue(NonPagedSystemMemory.Value);
            }
            if (PagedMemory.HasValue)
            {
                writer.WritePropertyName("paged_memory"u8);
                writer.WriteNumberValue(PagedMemory.Value);
            }
            if (PeakPagedMemory.HasValue)
            {
                writer.WritePropertyName("peak_paged_memory"u8);
                writer.WriteNumberValue(PeakPagedMemory.Value);
            }
            if (TimeStamp.HasValue)
            {
                writer.WritePropertyName("time_stamp"u8);
                writer.WriteStringValue(TimeStamp.Value, "O");
            }
            if (!(EnvironmentVariables is ChangeTrackingDictionary<string, string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("environment_variables"u8);
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (IsScmSite.HasValue)
            {
                writer.WritePropertyName("is_scm_site"u8);
                writer.WriteBooleanValue(IsScmSite.Value);
            }
            if (IsWebjob.HasValue)
            {
                writer.WritePropertyName("is_webjob"u8);
                writer.WriteBooleanValue(IsWebjob.Value);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
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

        ProcessInfoData IJsonModel<ProcessInfoData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProcessInfoData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProcessInfoData(document.RootElement, options);
        }

        internal static ProcessInfoData DeserializeProcessInfoData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            int? identifier = default;
            string deploymentName = default;
            string href = default;
            string minidump = default;
            bool? isProfileRunning = default;
            bool? isIisProfileRunning = default;
            double? iisProfileTimeoutInSeconds = default;
            string parent = default;
            IList<string> children = default;
            IList<ProcessThreadInfo> threads = default;
            IList<string> openFileHandles = default;
            IList<ProcessModuleInfoData> modules = default;
            string fileName = default;
            string commandLine = default;
            string userName = default;
            int? handleCount = default;
            int? moduleCount = default;
            int? threadCount = default;
            DateTimeOffset? startTime = default;
            string totalCpuTime = default;
            string userCpuTime = default;
            string privilegedCpuTime = default;
            long? workingSet = default;
            long? peakWorkingSet = default;
            long? privateMemory = default;
            long? virtualMemory = default;
            long? peakVirtualMemory = default;
            long? pagedSystemMemory = default;
            long? nonPagedSystemMemory = default;
            long? pagedMemory = default;
            long? peakPagedMemory = default;
            DateTimeOffset? timeStamp = default;
            IDictionary<string, string> environmentVariables = default;
            bool? isScmSite = default;
            bool? isWebjob = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("identifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identifier = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("deployment_name"u8))
                        {
                            deploymentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("href"u8))
                        {
                            href = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("minidump"u8))
                        {
                            minidump = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("is_profile_running"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isProfileRunning = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("is_iis_profile_running"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isIisProfileRunning = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("iis_profile_timeout_in_seconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iisProfileTimeoutInSeconds = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("parent"u8))
                        {
                            parent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("children"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            children = array;
                            continue;
                        }
                        if (property0.NameEquals("threads"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ProcessThreadInfo> array = new List<ProcessThreadInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ProcessThreadInfo.DeserializeProcessThreadInfo(item, options));
                            }
                            threads = array;
                            continue;
                        }
                        if (property0.NameEquals("open_file_handles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            openFileHandles = array;
                            continue;
                        }
                        if (property0.NameEquals("modules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ProcessModuleInfoData> array = new List<ProcessModuleInfoData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ProcessModuleInfoData.DeserializeProcessModuleInfoData(item, options));
                            }
                            modules = array;
                            continue;
                        }
                        if (property0.NameEquals("file_name"u8))
                        {
                            fileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("command_line"u8))
                        {
                            commandLine = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("user_name"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("handle_count"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            handleCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("module_count"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            moduleCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("thread_count"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            threadCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("start_time"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("total_cpu_time"u8))
                        {
                            totalCpuTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("user_cpu_time"u8))
                        {
                            userCpuTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privileged_cpu_time"u8))
                        {
                            privilegedCpuTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("working_set"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workingSet = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("peak_working_set"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakWorkingSet = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("private_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("virtual_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("peak_virtual_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakVirtualMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("paged_system_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pagedSystemMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("non_paged_system_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nonPagedSystemMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("paged_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pagedMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("peak_paged_memory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakPagedMemory = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("time_stamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("environment_variables"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            environmentVariables = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("is_scm_site"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isScmSite = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("is_webjob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isWebjob = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProcessInfoData(
                id,
                name,
                type,
                systemData,
                identifier,
                deploymentName,
                href,
                minidump,
                isProfileRunning,
                isIisProfileRunning,
                iisProfileTimeoutInSeconds,
                parent,
                children ?? new ChangeTrackingList<string>(),
                threads ?? new ChangeTrackingList<ProcessThreadInfo>(),
                openFileHandles ?? new ChangeTrackingList<string>(),
                modules ?? new ChangeTrackingList<ProcessModuleInfoData>(),
                fileName,
                commandLine,
                userName,
                handleCount,
                moduleCount,
                threadCount,
                startTime,
                totalCpuTime,
                userCpuTime,
                privilegedCpuTime,
                workingSet,
                peakWorkingSet,
                privateMemory,
                virtualMemory,
                peakVirtualMemory,
                pagedSystemMemory,
                nonPagedSystemMemory,
                pagedMemory,
                peakPagedMemory,
                timeStamp,
                environmentVariables ?? new ChangeTrackingDictionary<string, string>(),
                isScmSite,
                isWebjob,
                description,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProcessInfoData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProcessInfoData)} does not support '{options.Format}' format.");
            }
        }

        ProcessInfoData IPersistableModel<ProcessInfoData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProcessInfoData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProcessInfoData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProcessInfoData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
