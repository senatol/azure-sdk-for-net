// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Provides parameter values to a tag scoring function. </summary>
    public partial class TagScoringParameters
    {
        /// <summary> Initializes a new instance of <see cref="TagScoringParameters"/>. </summary>
        /// <param name="tagsParameter"> The name of the parameter passed in search queries to specify the list of tags to compare against the target field. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tagsParameter"/> is null. </exception>
        public TagScoringParameters(string tagsParameter)
        {
            if (tagsParameter == null)
            {
                throw new ArgumentNullException(nameof(tagsParameter));
            }

            TagsParameter = tagsParameter;
        }

        /// <summary> The name of the parameter passed in search queries to specify the list of tags to compare against the target field. </summary>
        public string TagsParameter { get; set; }
    }
}
