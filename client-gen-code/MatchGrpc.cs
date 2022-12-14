// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: match.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcMatch {
  public static partial class Match
  {
    static readonly string __ServiceName = "match.Match";

    static readonly grpc::Marshaller<global::GrpcMatch.C2sMatch> __Marshaller_match_C2sMatch = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcMatch.C2sMatch.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcMatch.S2cMatch> __Marshaller_match_S2cMatch = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcMatch.S2cMatch.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcMatch.C2sCancelMatch> __Marshaller_match_C2sCancelMatch = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcMatch.C2sCancelMatch.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcMatch.S2cCancelMatch> __Marshaller_match_S2cCancelMatch = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcMatch.S2cCancelMatch.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcMatch.C2sMatch, global::GrpcMatch.S2cMatch> __Method_Match = new grpc::Method<global::GrpcMatch.C2sMatch, global::GrpcMatch.S2cMatch>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Match",
        __Marshaller_match_C2sMatch,
        __Marshaller_match_S2cMatch);

    static readonly grpc::Method<global::GrpcMatch.C2sCancelMatch, global::GrpcMatch.S2cCancelMatch> __Method_CancelMatch = new grpc::Method<global::GrpcMatch.C2sCancelMatch, global::GrpcMatch.S2cCancelMatch>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CancelMatch",
        __Marshaller_match_C2sCancelMatch,
        __Marshaller_match_S2cCancelMatch);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcMatch.MatchReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Match</summary>
    public abstract partial class MatchBase
    {
      public virtual global::System.Threading.Tasks.Task Match(global::GrpcMatch.C2sMatch request, grpc::IServerStreamWriter<global::GrpcMatch.S2cMatch> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcMatch.S2cCancelMatch> CancelMatch(global::GrpcMatch.C2sCancelMatch request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Match</summary>
    public partial class MatchClient : grpc::ClientBase<MatchClient>
    {
      /// <summary>Creates a new client for Match</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MatchClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Match that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MatchClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MatchClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MatchClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::GrpcMatch.S2cMatch> Match(global::GrpcMatch.C2sMatch request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Match(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::GrpcMatch.S2cMatch> Match(global::GrpcMatch.C2sMatch request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Match, null, options, request);
      }
      public virtual global::GrpcMatch.S2cCancelMatch CancelMatch(global::GrpcMatch.C2sCancelMatch request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CancelMatch(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcMatch.S2cCancelMatch CancelMatch(global::GrpcMatch.C2sCancelMatch request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CancelMatch, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcMatch.S2cCancelMatch> CancelMatchAsync(global::GrpcMatch.C2sCancelMatch request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CancelMatchAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcMatch.S2cCancelMatch> CancelMatchAsync(global::GrpcMatch.C2sCancelMatch request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CancelMatch, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MatchClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MatchClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MatchBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Match, serviceImpl.Match)
          .AddMethod(__Method_CancelMatch, serviceImpl.CancelMatch).Build();
    }

  }
}
#endregion
