// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/lifesciences/v2beta/workflows.proto
// </auto-generated>
// Original file comments:
// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.LifeSciences.V2Beta {
  /// <summary>
  /// A service for running workflows, such as pipelines consisting of Docker
  /// containers.
  /// </summary>
  public static partial class WorkflowsServiceV2Beta
  {
    static readonly string __ServiceName = "google.cloud.lifesciences.v2beta.WorkflowsServiceV2Beta";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.LifeSciences.V2Beta.RunPipelineRequest> __Marshaller_google_cloud_lifesciences_v2beta_RunPipelineRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.LifeSciences.V2Beta.RunPipelineRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.LifeSciences.V2Beta.RunPipelineRequest, global::Google.LongRunning.Operation> __Method_RunPipeline = new grpc::Method<global::Google.Cloud.LifeSciences.V2Beta.RunPipelineRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RunPipeline",
        __Marshaller_google_cloud_lifesciences_v2beta_RunPipelineRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.LifeSciences.V2Beta.WorkflowsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of WorkflowsServiceV2Beta</summary>
    [grpc::BindServiceMethod(typeof(WorkflowsServiceV2Beta), "BindService")]
    public abstract partial class WorkflowsServiceV2BetaBase
    {
      /// <summary>
      /// Runs a pipeline.  The returned Operation's [metadata]
      /// [google.longrunning.Operation.metadata] field will contain a
      /// [google.cloud.lifesciences.v2beta.Metadata][google.cloud.lifesciences.v2beta.Metadata]
      /// object describing the status of the pipeline execution. The
      /// [response][google.longrunning.Operation.response] field will contain a
      /// [google.cloud.lifesciences.v2beta.RunPipelineResponse][google.cloud.lifesciences.v2beta.RunPipelineResponse]
      /// object if the pipeline completes successfully.
      ///
      /// **Note:** Before you can use this method, the *Life Sciences Service Agent*
      /// must have access to your project. This is done automatically when the
      /// Cloud Life Sciences API is first enabled, but if you delete this permission
      /// you must disable and re-enable the API to grant the Life Sciences
      /// Service Agent the required permissions.
      /// Authorization requires the following [Google
      /// IAM](https://cloud.google.com/iam/) permission:
      ///
      /// * `lifesciences.workflows.run`
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> RunPipeline(global::Google.Cloud.LifeSciences.V2Beta.RunPipelineRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for WorkflowsServiceV2Beta</summary>
    public partial class WorkflowsServiceV2BetaClient : grpc::ClientBase<WorkflowsServiceV2BetaClient>
    {
      /// <summary>Creates a new client for WorkflowsServiceV2Beta</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public WorkflowsServiceV2BetaClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for WorkflowsServiceV2Beta that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public WorkflowsServiceV2BetaClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected WorkflowsServiceV2BetaClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected WorkflowsServiceV2BetaClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Runs a pipeline.  The returned Operation's [metadata]
      /// [google.longrunning.Operation.metadata] field will contain a
      /// [google.cloud.lifesciences.v2beta.Metadata][google.cloud.lifesciences.v2beta.Metadata]
      /// object describing the status of the pipeline execution. The
      /// [response][google.longrunning.Operation.response] field will contain a
      /// [google.cloud.lifesciences.v2beta.RunPipelineResponse][google.cloud.lifesciences.v2beta.RunPipelineResponse]
      /// object if the pipeline completes successfully.
      ///
      /// **Note:** Before you can use this method, the *Life Sciences Service Agent*
      /// must have access to your project. This is done automatically when the
      /// Cloud Life Sciences API is first enabled, but if you delete this permission
      /// you must disable and re-enable the API to grant the Life Sciences
      /// Service Agent the required permissions.
      /// Authorization requires the following [Google
      /// IAM](https://cloud.google.com/iam/) permission:
      ///
      /// * `lifesciences.workflows.run`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation RunPipeline(global::Google.Cloud.LifeSciences.V2Beta.RunPipelineRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunPipeline(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Runs a pipeline.  The returned Operation's [metadata]
      /// [google.longrunning.Operation.metadata] field will contain a
      /// [google.cloud.lifesciences.v2beta.Metadata][google.cloud.lifesciences.v2beta.Metadata]
      /// object describing the status of the pipeline execution. The
      /// [response][google.longrunning.Operation.response] field will contain a
      /// [google.cloud.lifesciences.v2beta.RunPipelineResponse][google.cloud.lifesciences.v2beta.RunPipelineResponse]
      /// object if the pipeline completes successfully.
      ///
      /// **Note:** Before you can use this method, the *Life Sciences Service Agent*
      /// must have access to your project. This is done automatically when the
      /// Cloud Life Sciences API is first enabled, but if you delete this permission
      /// you must disable and re-enable the API to grant the Life Sciences
      /// Service Agent the required permissions.
      /// Authorization requires the following [Google
      /// IAM](https://cloud.google.com/iam/) permission:
      ///
      /// * `lifesciences.workflows.run`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation RunPipeline(global::Google.Cloud.LifeSciences.V2Beta.RunPipelineRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RunPipeline, null, options, request);
      }
      /// <summary>
      /// Runs a pipeline.  The returned Operation's [metadata]
      /// [google.longrunning.Operation.metadata] field will contain a
      /// [google.cloud.lifesciences.v2beta.Metadata][google.cloud.lifesciences.v2beta.Metadata]
      /// object describing the status of the pipeline execution. The
      /// [response][google.longrunning.Operation.response] field will contain a
      /// [google.cloud.lifesciences.v2beta.RunPipelineResponse][google.cloud.lifesciences.v2beta.RunPipelineResponse]
      /// object if the pipeline completes successfully.
      ///
      /// **Note:** Before you can use this method, the *Life Sciences Service Agent*
      /// must have access to your project. This is done automatically when the
      /// Cloud Life Sciences API is first enabled, but if you delete this permission
      /// you must disable and re-enable the API to grant the Life Sciences
      /// Service Agent the required permissions.
      /// Authorization requires the following [Google
      /// IAM](https://cloud.google.com/iam/) permission:
      ///
      /// * `lifesciences.workflows.run`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RunPipelineAsync(global::Google.Cloud.LifeSciences.V2Beta.RunPipelineRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunPipelineAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Runs a pipeline.  The returned Operation's [metadata]
      /// [google.longrunning.Operation.metadata] field will contain a
      /// [google.cloud.lifesciences.v2beta.Metadata][google.cloud.lifesciences.v2beta.Metadata]
      /// object describing the status of the pipeline execution. The
      /// [response][google.longrunning.Operation.response] field will contain a
      /// [google.cloud.lifesciences.v2beta.RunPipelineResponse][google.cloud.lifesciences.v2beta.RunPipelineResponse]
      /// object if the pipeline completes successfully.
      ///
      /// **Note:** Before you can use this method, the *Life Sciences Service Agent*
      /// must have access to your project. This is done automatically when the
      /// Cloud Life Sciences API is first enabled, but if you delete this permission
      /// you must disable and re-enable the API to grant the Life Sciences
      /// Service Agent the required permissions.
      /// Authorization requires the following [Google
      /// IAM](https://cloud.google.com/iam/) permission:
      ///
      /// * `lifesciences.workflows.run`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RunPipelineAsync(global::Google.Cloud.LifeSciences.V2Beta.RunPipelineRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RunPipeline, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override WorkflowsServiceV2BetaClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WorkflowsServiceV2BetaClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(WorkflowsServiceV2BetaBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RunPipeline, serviceImpl.RunPipeline).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WorkflowsServiceV2BetaBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RunPipeline, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.LifeSciences.V2Beta.RunPipelineRequest, global::Google.LongRunning.Operation>(serviceImpl.RunPipeline));
    }

  }
}
#endregion
