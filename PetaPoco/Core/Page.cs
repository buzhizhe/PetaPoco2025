using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PetaPoco
{
    /// <summary>
    /// Provides access to the result collection from a paged request.
    /// </summary>
    /// <remarks>
    /// Represents a paged result set, both providing access to the items on the current page and maintaining state information about the
    /// pagination for additional queries.
    /// </remarks>
    /// <typeparam name="T">The POCO type representing a single result record.</typeparam>
    public class Page<T>
    {
        /// <summary>
        ///     The current page number contained in this page of result set
        /// </summary>
        [JsonPropertyName("pageindex")]
        public long CurrentPage { get; set; }

        /// <summary>
        ///     The total number of pages in the full result set
        /// </summary>
        [JsonPropertyName("pagecount")]
        public long TotalPages { get; set; }

        /// <summary>
        ///     The total number of records in the full result set
        /// </summary>
        [JsonPropertyName("total")]
        public long TotalItems { get; set; }

        /// <summary>
        ///     The number of items per page
        /// </summary>
        [JsonPropertyName("pagesize")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        ///     The actual records on this page
        /// </summary>
        [JsonPropertyName("rows")]
        public List<T> Items { get; set; }

        /// <summary>
        ///     User property to hold anything.
        /// </summary>
        public object Context { get; set; }
    }
}
