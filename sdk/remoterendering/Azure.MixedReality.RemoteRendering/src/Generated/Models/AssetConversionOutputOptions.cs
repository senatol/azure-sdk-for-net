// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> Conversion output settings describe the destination of conversion output. </summary>
    public partial class AssetConversionOutputOptions
    {
        /// <summary> Initializes a new instance of <see cref="AssetConversionOutputOptions"/>. </summary>
        /// <param name="storageContainerUri"> The URI of the Azure blob storage container where the result of the conversion should be written to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainerUri"/> is null. </exception>
        public AssetConversionOutputOptions(Uri storageContainerUri)
        {
            if (storageContainerUri == null)
            {
                throw new ArgumentNullException(nameof(storageContainerUri));
            }

            StorageContainerUri = storageContainerUri;
        }

        /// <summary> Initializes a new instance of <see cref="AssetConversionOutputOptions"/>. </summary>
        /// <param name="storageContainerUri"> The URI of the Azure blob storage container where the result of the conversion should be written to. </param>
        /// <param name="storageContainerWriteSas"> An Azure blob storage container shared access signature giving write access to the storage container. Optional. If not provided, the Azure Remote Rendering account needs to be linked with the storage account containing the blob container. See https://docs.microsoft.com/azure/remote-rendering/how-tos/create-an-account#link-storage-accounts for details. For security purposes this field will never be filled out in responses bodies. </param>
        /// <param name="blobPrefix"> A prefix which gets prepended in front of all files produced by the conversion process. Will be treated as a virtual folder. Optional. If not provided, output files will be stored at the container root. </param>
        /// <param name="outputAssetFilename"> The file name of the output asset. Must end in '.arrAsset'. Optional. If not provided, file name will the same name as the input asset, with '.arrAsset' extension. </param>
        internal AssetConversionOutputOptions(Uri storageContainerUri, string storageContainerWriteSas, string blobPrefix, string outputAssetFilename)
        {
            StorageContainerUri = storageContainerUri;
            StorageContainerWriteSas = storageContainerWriteSas;
            BlobPrefix = blobPrefix;
            OutputAssetFilename = outputAssetFilename;
        }
        /// <summary> An Azure blob storage container shared access signature giving write access to the storage container. Optional. If not provided, the Azure Remote Rendering account needs to be linked with the storage account containing the blob container. See https://docs.microsoft.com/azure/remote-rendering/how-tos/create-an-account#link-storage-accounts for details. For security purposes this field will never be filled out in responses bodies. </summary>
        public string StorageContainerWriteSas { get; set; }
        /// <summary> A prefix which gets prepended in front of all files produced by the conversion process. Will be treated as a virtual folder. Optional. If not provided, output files will be stored at the container root. </summary>
        public string BlobPrefix { get; set; }
        /// <summary> The file name of the output asset. Must end in '.arrAsset'. Optional. If not provided, file name will the same name as the input asset, with '.arrAsset' extension. </summary>
        public string OutputAssetFilename { get; set; }
    }
}
