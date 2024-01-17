
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Com.Example.Grpc.Chat {
  public static class ChatService
  {
    static readonly string __ServiceName = "com.example.grpc.chat.ChatService";

    static readonly Marshaller<global::Com.Example.Grpc.Chat.ChatMessage> __Marshaller_ChatMessage = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.Chat.ChatMessage.Parser.ParseFrom);
    static readonly Marshaller<global::Com.Example.Grpc.Chat.ChatMessageFromServer> __Marshaller_ChatMessageFromServer = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.Chat.ChatMessageFromServer.Parser.ParseFrom);

    static readonly Method<global::Com.Example.Grpc.Chat.ChatMessage, global::Com.Example.Grpc.Chat.ChatMessageFromServer> __Method_chat = new Method<global::Com.Example.Grpc.Chat.ChatMessage, global::Com.Example.Grpc.Chat.ChatMessageFromServer>(
        MethodType.DuplexStreaming,
        __ServiceName,
        "chat",
        __Marshaller_ChatMessage,
        __Marshaller_ChatMessageFromServer);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.Example.Grpc.Chat.ChatReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ChatService</summary>
    public abstract class ChatServiceBase
    {
      public virtual global::System.Threading.Tasks.Task chat(IAsyncStreamReader<global::Com.Example.Grpc.Chat.ChatMessage> requestStream, IServerStreamWriter<global::Com.Example.Grpc.Chat.ChatMessageFromServer> responseStream, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ChatService</summary>
    public class ChatServiceClient : ClientBase<ChatServiceClient>
    {
      /// <summary>Creates a new client for ChatService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ChatServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ChatService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ChatServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ChatServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ChatServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual AsyncDuplexStreamingCall<global::Com.Example.Grpc.Chat.ChatMessage, global::Com.Example.Grpc.Chat.ChatMessageFromServer> chat(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return chat(new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncDuplexStreamingCall<global::Com.Example.Grpc.Chat.ChatMessage, global::Com.Example.Grpc.Chat.ChatMessageFromServer> chat(CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_chat, null, options);
      }
      protected override ChatServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ChatServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ChatServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_chat, serviceImpl.chat).Build();
    }

  }
}
#endregion
