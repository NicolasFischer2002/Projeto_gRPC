// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/calculosGeometricos.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Server_gRPC.Protos {
  public static partial class CalculoGeometrico
  {
    static readonly string __ServiceName = "calculosGeometricos.CalculoGeometrico";

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
    static readonly grpc::Marshaller<global::Server_gRPC.Protos.Triangulo> __Marshaller_calculosGeometricos_Triangulo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server_gRPC.Protos.Triangulo.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Server_gRPC.Protos.Area> __Marshaller_calculosGeometricos_Area = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server_gRPC.Protos.Area.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Server_gRPC.Protos.Retangulo> __Marshaller_calculosGeometricos_Retangulo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server_gRPC.Protos.Retangulo.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Server_gRPC.Protos.Triangulo, global::Server_gRPC.Protos.Area> __Method_AreaTriangulo = new grpc::Method<global::Server_gRPC.Protos.Triangulo, global::Server_gRPC.Protos.Area>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AreaTriangulo",
        __Marshaller_calculosGeometricos_Triangulo,
        __Marshaller_calculosGeometricos_Area);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Server_gRPC.Protos.Retangulo, global::Server_gRPC.Protos.Area> __Method_AreaRetangulo = new grpc::Method<global::Server_gRPC.Protos.Retangulo, global::Server_gRPC.Protos.Area>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AreaRetangulo",
        __Marshaller_calculosGeometricos_Retangulo,
        __Marshaller_calculosGeometricos_Area);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Server_gRPC.Protos.CalculosGeometricosReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CalculoGeometrico</summary>
    [grpc::BindServiceMethod(typeof(CalculoGeometrico), "BindService")]
    public abstract partial class CalculoGeometricoBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Server_gRPC.Protos.Area> AreaTriangulo(global::Server_gRPC.Protos.Triangulo request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Server_gRPC.Protos.Area> AreaRetangulo(global::Server_gRPC.Protos.Retangulo request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CalculoGeometricoBase serviceImpl)
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
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CalculoGeometricoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AreaTriangulo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Server_gRPC.Protos.Triangulo, global::Server_gRPC.Protos.Area>(serviceImpl.AreaTriangulo));
      serviceBinder.AddMethod(__Method_AreaRetangulo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Server_gRPC.Protos.Retangulo, global::Server_gRPC.Protos.Area>(serviceImpl.AreaRetangulo));
    }

  }
}
#endregion
