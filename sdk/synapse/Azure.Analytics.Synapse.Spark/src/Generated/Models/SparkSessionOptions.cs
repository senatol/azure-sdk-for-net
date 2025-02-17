// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkSessionOptions. </summary>
    public partial class SparkSessionOptions
    {
        /// <summary> Initializes a new instance of <see cref="SparkSessionOptions"/>. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public SparkSessionOptions(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Tags = new ChangeTrackingDictionary<string, string>();
            Name = name;
            Arguments = new ChangeTrackingList<string>();
            Jars = new ChangeTrackingList<string>();
            PythonFiles = new ChangeTrackingList<string>();
            Files = new ChangeTrackingList<string>();
            Archives = new ChangeTrackingList<string>();
            Configuration = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SparkSessionOptions"/>. </summary>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="artifactId"></param>
        /// <param name="name"></param>
        /// <param name="file"></param>
        /// <param name="className"></param>
        /// <param name="arguments"></param>
        /// <param name="jars"></param>
        /// <param name="pythonFiles"></param>
        /// <param name="files"></param>
        /// <param name="archives"></param>
        /// <param name="configuration"> Dictionary of &lt;string&gt;. </param>
        /// <param name="driverMemory"></param>
        /// <param name="driverCores"></param>
        /// <param name="executorMemory"></param>
        /// <param name="executorCores"></param>
        /// <param name="executorCount"></param>
        internal SparkSessionOptions(IDictionary<string, string> tags, string artifactId, string name, string file, string className, IList<string> arguments, IList<string> jars, IList<string> pythonFiles, IList<string> files, IList<string> archives, IDictionary<string, string> configuration, string driverMemory, int? driverCores, string executorMemory, int? executorCores, int? executorCount)
        {
            Tags = tags;
            ArtifactId = artifactId;
            Name = name;
            File = file;
            ClassName = className;
            Arguments = arguments;
            Jars = jars;
            PythonFiles = pythonFiles;
            Files = files;
            Archives = archives;
            Configuration = configuration;
            DriverMemory = driverMemory;
            DriverCores = driverCores;
            ExecutorMemory = executorMemory;
            ExecutorCores = executorCores;
            ExecutorCount = executorCount;
        }

        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the artifact id. </summary>
        public string ArtifactId { get; set; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the file. </summary>
        public string File { get; set; }
        /// <summary> Gets or sets the class name. </summary>
        public string ClassName { get; set; }
        /// <summary> Gets the arguments. </summary>
        public IList<string> Arguments { get; }
        /// <summary> Gets the jars. </summary>
        public IList<string> Jars { get; }
        /// <summary> Gets the python files. </summary>
        public IList<string> PythonFiles { get; }
        /// <summary> Gets the files. </summary>
        public IList<string> Files { get; }
        /// <summary> Gets the archives. </summary>
        public IList<string> Archives { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Configuration { get; }
        /// <summary> Gets or sets the driver memory. </summary>
        public string DriverMemory { get; set; }
        /// <summary> Gets or sets the driver cores. </summary>
        public int? DriverCores { get; set; }
        /// <summary> Gets or sets the executor memory. </summary>
        public string ExecutorMemory { get; set; }
        /// <summary> Gets or sets the executor cores. </summary>
        public int? ExecutorCores { get; set; }
        /// <summary> Gets or sets the executor count. </summary>
        public int? ExecutorCount { get; set; }
    }
}
