// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/calculosGeometricosVolumetricos.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPC_Server.Protos {
  public static partial class CalculoGeometricoVolumetrico
  {
    static readonly string __ServiceName = "calculosGeometricosVolumetricos.CalculoGeometricoVolumetrico";

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
    static readonly grpc::Marshaller<global::gRPC_Server.Protos.PiramideBaseQuadrada> __Marshaller_calculosGeometricosVolumetricos_PiramideBaseQuadrada = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC_Server.Protos.PiramideBaseQuadrada.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC_Server.Protos.Volume> __Marshaller_calculosGeometricosVolumetricos_Volume = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC_Server.Protos.Volume.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPC_Server.Protos.Paralelepipedo> __Marshaller_calculosGeometricosVolumetricos_Paralelepipedo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPC_Server.Protos.Paralelepipedo.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPC_Server.Protos.PiramideBaseQuadrada, global::gRPC_Server.Protos.Volume> __Method_VolumePiramideBaseQuadrada = new grpc::Method<global::gRPC_Server.Protos.PiramideBaseQuadrada, global::gRPC_Server.Protos.Volume>(
        grpc::MethodType.Unary,
        __ServiceName,
        "VolumePiramideBaseQuadrada",
        __Marshaller_calculosGeometricosVolumetricos_PiramideBaseQuadrada,
        __Marshaller_calculosGeometricosVolumetricos_Volume);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPC_Server.Protos.Paralelepipedo, global::gRPC_Server.Protos.Volume> __Method_VolumeParalelepipedo = new grpc::Method<global::gRPC_Server.Protos.Paralelepipedo, global::gRPC_Server.Protos.Volume>(
        grpc::MethodType.Unary,
        __ServiceName,
        "VolumeParalelepipedo",
        __Marshaller_calculosGeometricosVolumetricos_Paralelepipedo,
        __Marshaller_calculosGeometricosVolumetricos_Volume);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPC_Server.Protos.CalculosGeometricosVolumetricosReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for CalculoGeometricoVolumetrico</summary>
    public partial class CalculoGeometricoVolumetricoClient : grpc::ClientBase<CalculoGeometricoVolumetricoClient>
    {
      /// <summary>Creates a new client for CalculoGeometricoVolumetrico</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CalculoGeometricoVolumetricoClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CalculoGeometricoVolumetrico that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CalculoGeometricoVolumetricoClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CalculoGeometricoVolumetricoClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CalculoGeometricoVolumetricoClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPC_Server.Protos.Volume VolumePiramideBaseQuadrada(global::gRPC_Server.Protos.PiramideBaseQuadrada request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VolumePiramideBaseQuadrada(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPC_Server.Protos.Volume VolumePiramideBaseQuadrada(global::gRPC_Server.Protos.PiramideBaseQuadrada request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_VolumePiramideBaseQuadrada, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.Protos.Volume> VolumePiramideBaseQuadradaAsync(global::gRPC_Server.Protos.PiramideBaseQuadrada request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VolumePiramideBaseQuadradaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.Protos.Volume> VolumePiramideBaseQuadradaAsync(global::gRPC_Server.Protos.PiramideBaseQuadrada request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_VolumePiramideBaseQuadrada, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPC_Server.Protos.Volume VolumeParalelepipedo(global::gRPC_Server.Protos.Paralelepipedo request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VolumeParalelepipedo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPC_Server.Protos.Volume VolumeParalelepipedo(global::gRPC_Server.Protos.Paralelepipedo request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_VolumeParalelepipedo, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.Protos.Volume> VolumeParalelepipedoAsync(global::gRPC_Server.Protos.Paralelepipedo request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VolumeParalelepipedoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.Protos.Volume> VolumeParalelepipedoAsync(global::gRPC_Server.Protos.Paralelepipedo request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_VolumeParalelepipedo, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CalculoGeometricoVolumetricoClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CalculoGeometricoVolumetricoClient(configuration);
      }
    }

  }
}
#endregion
