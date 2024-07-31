// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gRPC Services/Protos/calculosGeometricosPlanos.proto
// </auto-generated>
// Original file comments:
// Indica que a vers�o 3 da sintaxe Protobuf est� sendo utilizada.
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPC_Server.Protos {
  /// <summary>
  /// Define o servi�o gRPC chamado 'CalculoGeometricoPlano'.
  /// Um servi�o cont�m uma ou mais RPC (Remote Procedure Calls) que o cliente pode chamar.
  /// </summary>
  public static partial class CalculoGeometricoPlano
  {
    static readonly string __ServiceName = "calculosGeometricosPlanos.CalculoGeometricoPlano";

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
    static readonly grpc::Marshaller<global::gRPC_Server.Protos.TrianguloRequest> __Marshaller_calculosGeometricosPlanos_TrianguloRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC_Server.Protos.TrianguloRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC_Server.Protos.AreaReply> __Marshaller_calculosGeometricosPlanos_AreaReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC_Server.Protos.AreaReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC_Server.Protos.RetanguloRequest> __Marshaller_calculosGeometricosPlanos_RetanguloRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC_Server.Protos.RetanguloRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPC_Server.Protos.TrianguloRequest, global::gRPC_Server.Protos.AreaReply> __Method_AreaTriangulo = new grpc::Method<global::gRPC_Server.Protos.TrianguloRequest, global::gRPC_Server.Protos.AreaReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AreaTriangulo",
        __Marshaller_calculosGeometricosPlanos_TrianguloRequest,
        __Marshaller_calculosGeometricosPlanos_AreaReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPC_Server.Protos.RetanguloRequest, global::gRPC_Server.Protos.AreaReply> __Method_AreaRetangulo = new grpc::Method<global::gRPC_Server.Protos.RetanguloRequest, global::gRPC_Server.Protos.AreaReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AreaRetangulo",
        __Marshaller_calculosGeometricosPlanos_RetanguloRequest,
        __Marshaller_calculosGeometricosPlanos_AreaReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPC_Server.Protos.CalculosGeometricosPlanosReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for CalculoGeometricoPlano</summary>
    public partial class CalculoGeometricoPlanoClient : grpc::ClientBase<CalculoGeometricoPlanoClient>
    {
      /// <summary>Creates a new client for CalculoGeometricoPlano</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CalculoGeometricoPlanoClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CalculoGeometricoPlano that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CalculoGeometricoPlanoClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CalculoGeometricoPlanoClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CalculoGeometricoPlanoClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Define um m�todo RPC chamado 'AreaTriangulo'.
      /// O cliente envia uma mensagem 'Triangulo' e recebe uma mensagem 'Area'.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPC_Server.Protos.AreaReply AreaTriangulo(global::gRPC_Server.Protos.TrianguloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AreaTriangulo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Define um m�todo RPC chamado 'AreaTriangulo'.
      /// O cliente envia uma mensagem 'Triangulo' e recebe uma mensagem 'Area'.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPC_Server.Protos.AreaReply AreaTriangulo(global::gRPC_Server.Protos.TrianguloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AreaTriangulo, null, options, request);
      }
      /// <summary>
      /// Define um m�todo RPC chamado 'AreaTriangulo'.
      /// O cliente envia uma mensagem 'Triangulo' e recebe uma mensagem 'Area'.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.Protos.AreaReply> AreaTrianguloAsync(global::gRPC_Server.Protos.TrianguloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AreaTrianguloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Define um m�todo RPC chamado 'AreaTriangulo'.
      /// O cliente envia uma mensagem 'Triangulo' e recebe uma mensagem 'Area'.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.Protos.AreaReply> AreaTrianguloAsync(global::gRPC_Server.Protos.TrianguloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AreaTriangulo, null, options, request);
      }
      /// <summary>
      /// Define um m�todo RPC chamado 'AreaRetangulo'.
      /// O cliente envia uma mensagem 'Retangulo' e recebe uma mensagem 'Area'.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPC_Server.Protos.AreaReply AreaRetangulo(global::gRPC_Server.Protos.RetanguloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AreaRetangulo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Define um m�todo RPC chamado 'AreaRetangulo'.
      /// O cliente envia uma mensagem 'Retangulo' e recebe uma mensagem 'Area'.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPC_Server.Protos.AreaReply AreaRetangulo(global::gRPC_Server.Protos.RetanguloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AreaRetangulo, null, options, request);
      }
      /// <summary>
      /// Define um m�todo RPC chamado 'AreaRetangulo'.
      /// O cliente envia uma mensagem 'Retangulo' e recebe uma mensagem 'Area'.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.Protos.AreaReply> AreaRetanguloAsync(global::gRPC_Server.Protos.RetanguloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AreaRetanguloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Define um m�todo RPC chamado 'AreaRetangulo'.
      /// O cliente envia uma mensagem 'Retangulo' e recebe uma mensagem 'Area'.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.Protos.AreaReply> AreaRetanguloAsync(global::gRPC_Server.Protos.RetanguloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AreaRetangulo, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CalculoGeometricoPlanoClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CalculoGeometricoPlanoClient(configuration);
      }
    }

  }
}
#endregion