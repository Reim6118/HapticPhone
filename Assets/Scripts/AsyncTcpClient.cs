//using System.Net.Sockets;
//using System.Threading.Tasks;

//public class AsyncTcpClient
//{
//    private TcpClient client;

//    public AsyncTcpClient()
//    {
//        client = new TcpClient();
//    }

//    public async Task ConnectAsync(string host, int port)
//    {
//        await client.ConnectAsync(host, port);
//    }

//    public async Task<int> SendAsync(byte[] data)
//    {
//        return await client.GetStream().WriteAsync(data, 0, data.Length);
//    }

//    public async Task<int> ReceiveAsync(byte[] buffer)
//    {
//        return await client.GetStream().ReadAsync(buffer, 0, buffer.Length);
//    }

//    public void Close()
//    {
//        client.Close();
//    }
//}
