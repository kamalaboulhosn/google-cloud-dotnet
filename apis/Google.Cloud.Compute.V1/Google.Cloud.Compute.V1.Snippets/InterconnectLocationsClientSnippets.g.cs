// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedInterconnectLocationsClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetInterconnectLocationRequest, CallSettings)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = InterconnectLocationsClient.Create();
            // Initialize request argument(s)
            GetInterconnectLocationRequest request = new GetInterconnectLocationRequest
            {
                Project = "",
                InterconnectLocation = "",
            };
            // Make the request
            InterconnectLocation response = interconnectLocationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInterconnectLocationRequest, CallSettings)
            // Additional: GetAsync(GetInterconnectLocationRequest, CancellationToken)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = await InterconnectLocationsClient.CreateAsync();
            // Initialize request argument(s)
            GetInterconnectLocationRequest request = new GetInterconnectLocationRequest
            {
                Project = "",
                InterconnectLocation = "",
            };
            // Make the request
            InterconnectLocation response = await interconnectLocationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = InterconnectLocationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectLocation = "";
            // Make the request
            InterconnectLocation response = interconnectLocationsClient.Get(project, interconnectLocation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = await InterconnectLocationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectLocation = "";
            // Make the request
            InterconnectLocation response = await interconnectLocationsClient.GetAsync(project, interconnectLocation);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListInterconnectLocationsRequest, CallSettings)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = InterconnectLocationsClient.Create();
            // Initialize request argument(s)
            ListInterconnectLocationsRequest request = new ListInterconnectLocationsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InterconnectLocationList, InterconnectLocation> response = interconnectLocationsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectLocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectLocationList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectLocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListInterconnectLocationsRequest, CallSettings)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = await InterconnectLocationsClient.CreateAsync();
            // Initialize request argument(s)
            ListInterconnectLocationsRequest request = new ListInterconnectLocationsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InterconnectLocationList, InterconnectLocation> response = interconnectLocationsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectLocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectLocationList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectLocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = InterconnectLocationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<InterconnectLocationList, InterconnectLocation> response = interconnectLocationsClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectLocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectLocationList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectLocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = await InterconnectLocationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<InterconnectLocationList, InterconnectLocation> response = interconnectLocationsClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectLocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectLocationList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectLocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
