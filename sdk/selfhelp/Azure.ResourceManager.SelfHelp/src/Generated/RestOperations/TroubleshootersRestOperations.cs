// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp
{
    internal partial class TroubleshootersRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of TroubleshootersRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public TroubleshootersRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCreateRequest(string scope, string troubleshooterName, TroubleshooterResourceData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/troubleshooters/", false);
            uri.AppendPath(troubleshooterName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates the specific troubleshooter action under a resource or subscription using the ‘solutionId’ and  ‘properties.parameters’ as the trigger. &lt;br/&gt; Troubleshooters are step-by-step interactive guidance that scope the problem by collecting additional inputs from you in each stage while troubleshooting an Azure issue. You will be guided down decision tree style workflow and the best possible solution will be presented at the end of the workflow. &lt;br/&gt; Create API creates the Troubleshooter API using ‘parameters’ and ‘solutionId’ &lt;br/&gt; After creating the Troubleshooter instance, the following APIs can be used:&lt;br/&gt; CONTINUE API: to move to the next step in the flow &lt;br/&gt;GET API: to identify the next step after executing the CONTINUE API.   &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note:&lt;/b&gt; ‘requiredParameters’ from solutions response must be passed via ‘properties. parameters’ in the request body of Troubleshooters API. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="data"> The required request body for this Troubleshooter resource creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="troubleshooterName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TroubleshooterResourceData>> CreateAsync(string scope, string troubleshooterName, TroubleshooterResourceData data, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (troubleshooterName == null)
            {
                throw new ArgumentNullException(nameof(troubleshooterName));
            }
            if (troubleshooterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(troubleshooterName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateRequest(scope, troubleshooterName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        TroubleshooterResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TroubleshooterResourceData.DeserializeTroubleshooterResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates the specific troubleshooter action under a resource or subscription using the ‘solutionId’ and  ‘properties.parameters’ as the trigger. &lt;br/&gt; Troubleshooters are step-by-step interactive guidance that scope the problem by collecting additional inputs from you in each stage while troubleshooting an Azure issue. You will be guided down decision tree style workflow and the best possible solution will be presented at the end of the workflow. &lt;br/&gt; Create API creates the Troubleshooter API using ‘parameters’ and ‘solutionId’ &lt;br/&gt; After creating the Troubleshooter instance, the following APIs can be used:&lt;br/&gt; CONTINUE API: to move to the next step in the flow &lt;br/&gt;GET API: to identify the next step after executing the CONTINUE API.   &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note:&lt;/b&gt; ‘requiredParameters’ from solutions response must be passed via ‘properties. parameters’ in the request body of Troubleshooters API. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="data"> The required request body for this Troubleshooter resource creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="troubleshooterName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TroubleshooterResourceData> Create(string scope, string troubleshooterName, TroubleshooterResourceData data, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (troubleshooterName == null)
            {
                throw new ArgumentNullException(nameof(troubleshooterName));
            }
            if (troubleshooterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(troubleshooterName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateRequest(scope, troubleshooterName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        TroubleshooterResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TroubleshooterResourceData.DeserializeTroubleshooterResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string scope, string troubleshooterName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/troubleshooters/", false);
            uri.AppendPath(troubleshooterName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets troubleshooter instance result which includes the step status/result of the troubleshooter resource name that is being executed.&lt;br/&gt; Get API is used to retrieve the result of a Troubleshooter instance, which includes the status and result of each step in the Troubleshooter workflow. This API requires the Troubleshooter resource name that was created using the Create API. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="troubleshooterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TroubleshooterResourceData>> GetAsync(string scope, string troubleshooterName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (troubleshooterName == null)
            {
                throw new ArgumentNullException(nameof(troubleshooterName));
            }
            if (troubleshooterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(troubleshooterName));
            }

            using var message = CreateGetRequest(scope, troubleshooterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TroubleshooterResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TroubleshooterResourceData.DeserializeTroubleshooterResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TroubleshooterResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets troubleshooter instance result which includes the step status/result of the troubleshooter resource name that is being executed.&lt;br/&gt; Get API is used to retrieve the result of a Troubleshooter instance, which includes the status and result of each step in the Troubleshooter workflow. This API requires the Troubleshooter resource name that was created using the Create API. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="troubleshooterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TroubleshooterResourceData> Get(string scope, string troubleshooterName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (troubleshooterName == null)
            {
                throw new ArgumentNullException(nameof(troubleshooterName));
            }
            if (troubleshooterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(troubleshooterName));
            }

            using var message = CreateGetRequest(scope, troubleshooterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TroubleshooterResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TroubleshooterResourceData.DeserializeTroubleshooterResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TroubleshooterResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateContinueRequest(string scope, string troubleshooterName, ContinueRequestBody continueRequestBody)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/troubleshooters/", false);
            uri.AppendPath(troubleshooterName, true);
            uri.AppendPath("/continue", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (continueRequestBody != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(continueRequestBody);
                request.Content = content;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Uses ‘stepId’ and ‘responses’ as the trigger to continue the troubleshooting steps for the respective troubleshooter resource name. &lt;br/&gt;Continue API is used to provide inputs that are required for the specific troubleshooter to progress into the next step in the process. This API is used after the Troubleshooter has been created using the Create API. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="continueRequestBody"> The required request body for going to next step in Troubleshooter resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="troubleshooterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> ContinueAsync(string scope, string troubleshooterName, ContinueRequestBody continueRequestBody = null, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (troubleshooterName == null)
            {
                throw new ArgumentNullException(nameof(troubleshooterName));
            }
            if (troubleshooterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(troubleshooterName));
            }

            using var message = CreateContinueRequest(scope, troubleshooterName, continueRequestBody);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Uses ‘stepId’ and ‘responses’ as the trigger to continue the troubleshooting steps for the respective troubleshooter resource name. &lt;br/&gt;Continue API is used to provide inputs that are required for the specific troubleshooter to progress into the next step in the process. This API is used after the Troubleshooter has been created using the Create API. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="continueRequestBody"> The required request body for going to next step in Troubleshooter resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="troubleshooterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Continue(string scope, string troubleshooterName, ContinueRequestBody continueRequestBody = null, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (troubleshooterName == null)
            {
                throw new ArgumentNullException(nameof(troubleshooterName));
            }
            if (troubleshooterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(troubleshooterName));
            }

            using var message = CreateContinueRequest(scope, troubleshooterName, continueRequestBody);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateEndRequest(string scope, string troubleshooterName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/troubleshooters/", false);
            uri.AppendPath(troubleshooterName, true);
            uri.AppendPath("/end", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Ends the troubleshooter action. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="troubleshooterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> EndAsync(string scope, string troubleshooterName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (troubleshooterName == null)
            {
                throw new ArgumentNullException(nameof(troubleshooterName));
            }
            if (troubleshooterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(troubleshooterName));
            }

            using var message = CreateEndRequest(scope, troubleshooterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Ends the troubleshooter action. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="troubleshooterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response End(string scope, string troubleshooterName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (troubleshooterName == null)
            {
                throw new ArgumentNullException(nameof(troubleshooterName));
            }
            if (troubleshooterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(troubleshooterName));
            }

            using var message = CreateEndRequest(scope, troubleshooterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRestartRequest(string scope, string troubleshooterName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/troubleshooters/", false);
            uri.AppendPath(troubleshooterName, true);
            uri.AppendPath("/restart", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Restarts the troubleshooter API using applicable troubleshooter resource name as the input.&lt;br/&gt; It returns new resource name which should be used in subsequent request. The old resource name is obsolete after this API is invoked. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="troubleshooterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RestartTroubleshooterResult>> RestartAsync(string scope, string troubleshooterName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (troubleshooterName == null)
            {
                throw new ArgumentNullException(nameof(troubleshooterName));
            }
            if (troubleshooterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(troubleshooterName));
            }

            using var message = CreateRestartRequest(scope, troubleshooterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestartTroubleshooterResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RestartTroubleshooterResult.DeserializeRestartTroubleshooterResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Restarts the troubleshooter API using applicable troubleshooter resource name as the input.&lt;br/&gt; It returns new resource name which should be used in subsequent request. The old resource name is obsolete after this API is invoked. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="troubleshooterName"> Troubleshooter resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="troubleshooterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="troubleshooterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RestartTroubleshooterResult> Restart(string scope, string troubleshooterName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (troubleshooterName == null)
            {
                throw new ArgumentNullException(nameof(troubleshooterName));
            }
            if (troubleshooterName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(troubleshooterName));
            }

            using var message = CreateRestartRequest(scope, troubleshooterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestartTroubleshooterResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RestartTroubleshooterResult.DeserializeRestartTroubleshooterResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
