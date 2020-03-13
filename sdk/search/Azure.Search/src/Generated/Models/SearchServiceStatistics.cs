// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Models
{
    /// <summary> Response from a get service statistics request. If successful, it includes service level counters and limits. </summary>
    public partial class SearchServiceStatistics
    {
        /// <summary> Service level resource counters. </summary>
        public SearchServiceCounters Counters { get; set; } = new SearchServiceCounters();
        /// <summary> Service level general limits. </summary>
        public SearchServiceLimits Limits { get; set; } = new SearchServiceLimits();
    }
}