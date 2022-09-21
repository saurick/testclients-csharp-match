using Grpc.Core;
using grpc = global::Grpc.Core;
using tasks = System.Threading.Tasks;

namespace MatchGrpc
{
    class Match
    {
        public class MatchClient
        {
            readonly GrpcMatch.Match.MatchClient client;

            public MatchClient(GrpcMatch.Match.MatchClient client)
            {
                this.client = client;
            }
            
            //  进行匹配
            public async tasks.Task Match(string playerToken)
            {
                try
                {
                    GrpcMatch.C2sMatch c2sMatch = new GrpcMatch.C2sMatch { };
                    var token = playerToken;
                    Metadata headers = new Metadata { { "token", token } };
                    using (var call = client.Match(c2sMatch, headers))
                    {
                        var responseStream = call.ResponseStream;
                        while (await responseStream.MoveNext())
                        {
                            var msg = responseStream.Current;
                            Api.Utils.Log("Msg: {0}\n", msg.Msg);
                            Api.Utils.Log("ServerInfo: {0}\n", msg.ServerInfo);
                        }
                    }
                }
                catch (grpc::RpcException e)
                {
                    Api.Utils.Log("RPC failed: " + e);
                    throw;
                }
            }

            //  取消匹配
             public void CancelMatch(string playerToken)
            {
                try
                {
                    GrpcMatch.C2sCancelMatch c2sCancelMatch = new GrpcMatch.C2sCancelMatch { };
                    var token = playerToken;
                    grpc::Metadata headers = new grpc::Metadata { { "token", token } };
                    client.CancelMatch(c2sCancelMatch, headers);
                }
                catch (grpc::RpcException e)
                {
                    Api.Utils.Log("RPC failed: " + e);
                    throw;
                }
            }
        }
    }
}