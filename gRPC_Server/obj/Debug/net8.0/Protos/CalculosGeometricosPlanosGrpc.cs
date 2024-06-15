// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/calculosGeometricosPlanos.proto
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
    static readonly grpc::Marshaller<global::gRPC_Server.Protos.Triangulo> __Marshaller_calculosGeometricosPlanos_Triangulo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC_Server.Protos.Triangulo.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC_Server.Protos.Area> __Marshaller_calculosGeometricosPlanos_Area = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC_Server.Protos.Area.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC_Server.Protos.Retangulo> __Marshaller_calculosGeometricosPlanos_Retangulo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC_Server.Protos.Retangulo.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPC_Server.Protos.Triangulo, global::gRPC_Server.Protos.Area> __Method_AreaTriangulo = new grpc::Method<global::gRPC_Server.Protos.Triangulo, global::gRPC_Server.Protos.Area>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AreaTriangulo",
        __Marshaller_calculosGeometricosPlanos_Triangulo,
        __Marshaller_calculosGeometricosPlanos_Area);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPC_Server.Protos.Retangulo, global::gRPC_Server.Protos.Area> __Method_AreaRetangulo = new grpc::Method<global::gRPC_Server.Protos.Retangulo, global::gRPC_Server.Protos.Area>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AreaRetangulo",
        __Marshaller_calculosGeometricosPlanos_Retangulo,
        __Marshaller_calculosGeometricosPlanos_Area);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPC_Server.Protos.CalculosGeometricosPlanosReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CalculoGeometricoPlano</summary>
    [grpc::BindServiceMethod(typeof(CalculoGeometricoPlano), "BindService")]
    public abstract partial class CalculoGeometricoPlanoBase
    {
      /// <summary>
      /// Define um m�todo RPC chamado 'AreaTriangulo'.
      /// O cliente envia uma mensagem 'Triangulo' e recebe uma mensagem 'Area'.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPC_Server.Protos.Area> AreaTriangulo(global::gRPC_Server.Protos.Triangulo request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Define um m�todo RPC chamado 'AreaRetangulo'.
      /// O cliente envia uma mensagem 'Retangulo' e recebe uma mensagem 'Area'.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPC_Server.Protos.Area> AreaRetangulo(global::gRPC_Server.Protos.Retangulo request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CalculoGeometricoPlanoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AreaTriangulo, serviceImpl.AreaTriangulo)
          .AddMethod(__Method_AreaRetangulo, serviceImpl.AreaRetangulo).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CalculoGeometricoPlanoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AreaTriangulo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Server.Protos.Triangulo, global::gRPC_Server.Protos.Area>(serviceImpl.AreaTriangulo));
      serviceBinder.AddMethod(__Method_AreaRetangulo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Server.Protos.Retangulo, global::gRPC_Server.Protos.Area>(serviceImpl.AreaRetangulo));
    }

  }
}
#endregion
