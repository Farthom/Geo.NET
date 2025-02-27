﻿// <copyright file="ReverseGeocodeProvidedLocation.cs" company="Geo.NET">
// Copyright (c) Geo.NET.
// Licensed under the MIT license. See the LICENSE file in the solution root for full license information.
// </copyright>

namespace Geo.MapQuest.Models.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// The location information provided to the reverse geocode request.
    /// </summary>
    public class ReverseGeocodeProvidedLocation
    {
        /// <summary>
        /// Gets or sets the location provided.
        /// </summary>
        [JsonProperty("latLng")]
        public Coordinate Coordinate { get; set; }
    }
}
