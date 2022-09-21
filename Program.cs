using grpc = global::Grpc.Core;

namespace Match
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length < 3) {
                return 1;
            }
            string behavior = args[1];  //  用户匹配行为
            string playerToken = args[2];   //  用户token
            string port = args[3];  //  连接服务器的端口号
            var channel = new grpc::Channel("127.0.0.1:" + port, grpc::ChannelCredentials.Insecure);
            var matchClient = new MatchGrpc.Match.MatchClient(new GrpcMatch.Match.MatchClient(channel));
            //  进行匹配
            if (behavior == "match")
            {
                matchClient.Match(playerToken).Wait();
            }
            //  取消匹配     
            if (behavior == "cancel")
            {
                matchClient.CancelMatch(playerToken);
            }    
            return 0;     
        }
    }
}
