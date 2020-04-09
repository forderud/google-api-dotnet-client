// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.45.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Display & Video 360 API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/display-video/'>Display & Video 360 API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20200407 (1923)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/display-video/'>
 *              https://developers.google.com/display-video/</a>
 *      <tr><th>Discovery Name<td>displayvideo
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Display & Video 360 API can be found at
 * <a href='https://developers.google.com/display-video/'>https://developers.google.com/display-video/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.DisplayVideo.v1
{
    /// <summary>The DisplayVideo Service.</summary>
    public class DisplayVideoService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DisplayVideoService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DisplayVideoService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            media = new MediaResource(this);
            sdfdownloadtasks = new SdfdownloadtasksResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "displayvideo"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            get { return BaseUriOverride ?? "https://displayvideo.googleapis.com/"; }
        #else
            get { return "https://displayvideo.googleapis.com/"; }
        #endif
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://displayvideo.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Display & Video 360 API.</summary>
        public class Scope
        {
            /// <summary>Create, see, edit, and permanently delete your Display & Video 360 entities and
            /// reports</summary>
            public static string DisplayVideo = "https://www.googleapis.com/auth/display-video";

            /// <summary>View and manage your reports in DoubleClick Bid Manager</summary>
            public static string Doubleclickbidmanager = "https://www.googleapis.com/auth/doubleclickbidmanager";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Display & Video 360 API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Create, see, edit, and permanently delete your Display & Video 360 entities and
            /// reports</summary>
            public const string DisplayVideo = "https://www.googleapis.com/auth/display-video";

            /// <summary>View and manage your reports in DoubleClick Bid Manager</summary>
            public const string Doubleclickbidmanager = "https://www.googleapis.com/auth/doubleclickbidmanager";

        }



        private readonly MediaResource media;

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media
        {
            get { return media; }
        }

        private readonly SdfdownloadtasksResource sdfdownloadtasks;

        /// <summary>Gets the Sdfdownloadtasks resource.</summary>
        public virtual SdfdownloadtasksResource Sdfdownloadtasks
        {
            get { return sdfdownloadtasks; }
        }
    }

    ///<summary>A base abstract class for DisplayVideo requests.</summary>
    public abstract class DisplayVideoBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new DisplayVideoBaseServiceRequest instance.</summary>
        protected DisplayVideoBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes DisplayVideo parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Downloads media. Download is supported on the URI `/download/{resource_name=**}?alt=media.`
        ///
        /// **Note**: Download requests will not be successful without including `alt=media` query string.</summary>
        /// <param name="resourceName">Name of the media that is being downloaded.  See ReadRequest.resource_name.</param>
        public virtual DownloadRequest Download(string resourceName)
        {
            return new DownloadRequest(service, resourceName);
        }

        /// <summary>Downloads media. Download is supported on the URI `/download/{resource_name=**}?alt=media.`
        ///
        /// **Note**: Download requests will not be successful without including `alt=media` query string.</summary>
        public class DownloadRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.GoogleBytestreamMedia>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string resourceName)
                : base(service)
            {
                ResourceName = resourceName;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }


            /// <summary>Name of the media that is being downloaded.  See ReadRequest.resource_name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "download"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "download/{+resourceName}"; }
            }

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "resourceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^.*$",
                    });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>Warning: This method hides download errors; use <see cref="DownloadWithStatus"/> instead.</para>
            /// </summary>
            public virtual void Download(System.IO.Stream stream)
            {
                MediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                return MediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                return MediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                return MediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            #if !NET40
            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = new Google.Apis.Download.MediaDownloader(Service);
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = new Google.Apis.Download.MediaDownloader(Service);
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
            #endif

        }
    }

    /// <summary>The "sdfdownloadtasks" collection of methods.</summary>
    public class SdfdownloadtasksResource
    {
        private const string Resource = "sdfdownloadtasks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SdfdownloadtasksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            operations = new OperationsResource(service);

        }

        private readonly OperationsResource operations;

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations
        {
            get { return operations; }
        }

        /// <summary>The "operations" collection of methods.</summary>
        public class OperationsResource
        {
            private const string Resource = "operations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public OperationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Gets the latest state of an asynchronous SDF download task operation. Clients should poll this
            /// method at intervals of 30 seconds.</summary>
            /// <param name="name">The name of the operation resource.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the latest state of an asynchronous SDF download task operation. Clients should poll this
            /// method at intervals of 30 seconds.</summary>
            public class GetRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Operation>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>The name of the operation resource.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName
                {
                    get { return "get"; }
                }

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod
                {
                    get { return "GET"; }
                }

                ///<summary>Gets the REST path.</summary>
                public override string RestPath
                {
                    get { return "v1/{+name}"; }
                }

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^sdfdownloadtasks/operations/[^/]+$",
                        });
                }

            }
        }

        /// <summary>Creates an SDF Download Task. Returns an Operation.
        ///
        /// An SDF Download Task is a long-running, asynchronous operation. The metadata type of this operation is
        /// SdfDownloadTaskMetadata. If the request is successful, the response type of the operation is
        /// SdfDownloadTask. The response will not include the download files, which must be retrieved with
        /// media.download. The state of operation can be retrieved with sdfdownloadtask.operations.get.
        ///
        /// Any errors can be found in the error.message. Note that error.details is expected to be empty.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.DisplayVideo.v1.Data.CreateSdfDownloadTaskRequest body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates an SDF Download Task. Returns an Operation.
        ///
        /// An SDF Download Task is a long-running, asynchronous operation. The metadata type of this operation is
        /// SdfDownloadTaskMetadata. If the request is successful, the response type of the operation is
        /// SdfDownloadTask. The response will not include the download files, which must be retrieved with
        /// media.download. The state of operation can be retrieved with sdfdownloadtask.operations.get.
        ///
        /// Any errors can be found in the error.message. Note that error.details is expected to be empty.</summary>
        public class CreateRequest : DisplayVideoBaseServiceRequest<Google.Apis.DisplayVideo.v1.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DisplayVideo.v1.Data.CreateSdfDownloadTaskRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DisplayVideo.v1.Data.CreateSdfDownloadTaskRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "create"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/sdfdownloadtasks"; }
            }

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}

namespace Google.Apis.DisplayVideo.v1.Data
{    

    /// <summary>Request message for [SdfDownloadTaskService.CreateSdfDownloadTask].</summary>
    public class CreateSdfDownloadTaskRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the advertiser to download SDF for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Filters on entities by their entity IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idFilter")]
        public virtual IdFilter IdFilter { get; set; } 

        /// <summary>Filters on Inventory Sources by their IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceFilter")]
        public virtual InventorySourceFilter InventorySourceFilter { get; set; } 

        /// <summary>Filters on selected file types. The entities in each file are filtered by a chosen set of filter
        /// entities. The filter entities must be the same type as, or a parent type of, the selected file
        /// types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentEntityFilter")]
        public virtual ParentEntityFilter ParentEntityFilter { get; set; } 

        /// <summary>The ID of the partner to download SDF for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerId")]
        public virtual System.Nullable<long> PartnerId { get; set; } 

        /// <summary>Required. The SDF version of the downloaded file. If set to `SDF_VERSION_UNSPECIFIED`, this will
        /// default to the version specified by the advertiser or partner identified by `root_id`. An advertiser
        /// inherits its SDF version from its partner unless configured otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Media resource.</summary>
    public class GoogleBytestreamMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the media resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A filtering option that filters entities by their entity IDs.</summary>
    public class IdFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>TrueView Ads to download by ID. All IDs must belong to the same Advertiser or Partner specified in
        /// CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupAdIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> AdGroupAdIds { get; set; } 

        /// <summary>TrueView Ad Groups to download by ID. All IDs must belong to the same Advertiser or Partner
        /// specified in CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> AdGroupIds { get; set; } 

        /// <summary>Campaigns to download by ID. All IDs must belong to the same Advertiser or Partner specified in
        /// CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> CampaignIds { get; set; } 

        /// <summary>Insertion Orders to download by ID. All IDs must belong to the same Advertiser or Partner specified
        /// in CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertionOrderIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> InsertionOrderIds { get; set; } 

        /// <summary>Line Items to download by ID. All IDs must belong to the same Advertiser or Partner specified in
        /// CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> LineItemIds { get; set; } 

        /// <summary>Media Products to download by ID. All IDs must belong to the same Advertiser or Partner specified
        /// in CreateSdfDownloadTaskRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaProductIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> MediaProductIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A filtering option for filtering on Inventory Source entities.</summary>
    public class InventorySourceFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Inventory Sources to download by ID. All IDs must belong to the same Advertiser or Partner
        /// specified in CreateSdfDownloadTaskRequest. Leave empty to download all Inventory Sources for the selected
        /// Advertiser or Partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySourceIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> InventorySourceIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the value is `false`, it means the operation is still in progress. If `true`, the operation is
        /// completed, and either `error` or `response` is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; } 

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; } 

        /// <summary>Service-specific metadata associated with the operation.  It typically contains progress
        /// information and common metadata such as create time. Some services might not provide such metadata.  Any
        /// method that returns a long-running operation should document the metadata type, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string,object> Metadata { get; set; } 

        /// <summary>The server-assigned name, which is only unique within the same service that originally returns it.
        /// If you use the default HTTP mapping, the `name` should be a resource name ending with
        /// `operations/{unique_id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The normal response of the operation in case of success.  If the original method returns no data on
        /// success, such as `Delete`, the response is `google.protobuf.Empty`.  If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource.  For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name.  For example, if the original method name
        /// is `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string,object> Response { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A filtering option that filters on selected file types belonging to a chosen set of filter
    /// entities.</summary>
    public class ParentEntityFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. File types that will be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
        public virtual System.Collections.Generic.IList<string> FileType { get; set; } 

        /// <summary>The IDs of the specified filter type. This is used to filter entities to fetch. If filter type is
        /// not `FILTER_TYPE_NONE`, at least one ID must be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> FilterIds { get; set; } 

        /// <summary>Required. Filter type used to filter fetched entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterType")]
        public virtual string FilterType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Type for the response returned by [SdfDownloadTaskService.CreateSdfDownloadTask].</summary>
    public class SdfDownloadTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A resource name to be used in media.download to Download the prepared files. Resource names have
        /// the format `download/sdfdownloadtasks/media/{media_id}`. `media_id` will be made available by the long
        /// running operation service once the task status is done.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Type for the metadata returned by [SdfDownloadTaskService.CreateSdfDownloadTask].</summary>
    public class SdfDownloadTaskMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time when the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>The time when execution was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>The SDF version used to execute this download task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status`
    /// message contains three pieces of data: error code, error message, and error details.
    ///
    /// You can find out more about this error model and how to work with it in the [API Design
    /// Guide](https://cloud.google.com/apis/design/errors).</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; } 

        /// <summary>A list of messages that carry the error details.  There is a common set of message types for APIs
        /// to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string,object>> Details { get; set; } 

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
