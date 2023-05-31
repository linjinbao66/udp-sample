using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program 
{

    static void Main()
    {
        Console.WriteLine("Hello, World!");
        receive();
    }

    static void receive()
    {

        string ipAddress = "192.168.0.1"; //外部接口地址
        int port = 1234; //外部接口端口

        UdpClient udpClient = new UdpClient();
        udpClient.Connect(ipAddress, port);

        try
        {
            Console.WriteLine("Server will listen on ip "+ ipAddress + ", port: 1234");
            // 接收数据包
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            byte[] receivedData = udpClient.Receive(ref remoteEP);

            string receivedMessage = Encoding.UTF8.GetString(receivedData);

            Console.WriteLine("Received UDP message: " + receivedMessage);
            Console.WriteLine("From: " + remoteEP.Address + ":" + remoteEP.Port);

            var jsonObject = System.Text.Json.JsonSerializer.Deserialize<GetPData2>(receivedMessage);
            if(jsonObject != null){
                Console.WriteLine("GetPData2: " + jsonObject.ToString());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            udpClient.Close();
        }
    }
}

class GetPData2
{
    public double Handle_L_Pin2 { get; set; }
    public double Handle_L_Pin4 { get; set; }
    public double Handle_L_Pin7 { get; set; }
    public double Handle_R_Pin2 { get; set; }
    public double Handle_R_Pin4 { get; set; }
    public double Handle_R_Pin7 { get; set; }
    public double Handle_1_Pin1 { get; set; }
    public double Handle_1_Pin3 { get; set; }
    public double Handle_2_Pin1 { get; set; }
    public double Handle_2_Pin3 { get; set; }
    public bool NFU_1_POWER_FAILURE_ALARM { get; set; }
    public bool NFU_1_TO_ABB_RPM_INC_S3 { get; set; }
    public bool NFU_1_TO_ABB_RPM_DEC_S4 { get; set; }
    public bool NFU_1_TO_ABB_NFU_ENABLE_NO_S2 { get; set; }
    public bool NFU_1_TO_WARTSILA_NFU_ENABLE_NC_S2 { get; set; }
    public bool NFU_1_TO_WARTSILA_NFU_CW_S5 { get; set; }
    public bool NFU_1_TO_WARTSILA_NFU_CCW_S6 { get; set; }
    public bool NFU_2_POWER_FAILURE_ALARM { get; set; }
    public bool NFU_2_TO_ABB_RPM_INC_S3 { get; set; }
    public bool NFU_2_TO_ABB_RPM_DEC_S4 { get; set; }
    public bool NFU_2_TO_ABB_NFU_ENABLE_NO_S2 { get; set; }
    public bool NFU_2_TO_WARTSILA_NFU_ENABLE_NC_S2 { get; set; }
    public bool NFU_2_TO_WARTSILA_NFU_CW_S5 { get; set; }
    public bool NFU_2_TO_WARTSILA_NFU_CCW_S6 { get; set; }

    public override string ToString()
    {
        return $"Handle_L_Pin2: {Handle_L_Pin2}, " +
               $"Handle_L_Pin4: {Handle_L_Pin4}, " +
               $"Handle_L_Pin7: {Handle_L_Pin7}, " +
               $"Handle_R_Pin2: {Handle_R_Pin2}, " +
               $"Handle_R_Pin4: {Handle_R_Pin4}, " +
               $"Handle_R_Pin7: {Handle_R_Pin7}, " +
               $"Handle_1_Pin1: {Handle_1_Pin1}, " +
               $"Handle_1_Pin3: {Handle_1_Pin3}, " +
               $"Handle_2_Pin1: {Handle_2_Pin1}, " +
               $"Handle_2_Pin3: {Handle_2_Pin3}, " +
               $"NFU_1_POWER_FAILURE_ALARM: {NFU_1_POWER_FAILURE_ALARM}, " +
               $"NFU_1_TO_ABB_RPM_INC_S3: {NFU_1_TO_ABB_RPM_INC_S3}, " +
               $"NFU_1_TO_ABB_RPM_DEC_S4: {NFU_1_TO_ABB_RPM_DEC_S4}, " +
               $"NFU_1_TO_ABB_NFU_ENABLE_NO_S2: {NFU_1_TO_ABB_NFU_ENABLE_NO_S2}, " +
               $"NFU_1_TO_WARTSILA_NFU_ENABLE_NC_S2: {NFU_1_TO_WARTSILA_NFU_ENABLE_NC_S2}, " +
               $"NFU_1_TO_WARTSILA_NFU_CW_S5: {NFU_1_TO_WARTSILA_NFU_CW_S5}, " +
               $"NFU_1_TO_WARTSILA_NFU_CCW_S6: {NFU_1_TO_WARTSILA_NFU_CCW_S6}, " +
               $"NFU_2_POWER_FAILURE_ALARM: {NFU_2_POWER_FAILURE_ALARM}, " +
               $"NFU_2_TO_ABB_RPM_INC_S3: {NFU_2_TO_ABB_RPM_INC_S3}, " +
               $"NFU_2_TO_ABB_RPM_DEC_S4: {NFU_2_TO_ABB_RPM_DEC_S4}, " +
               $"NFU_2_TO_ABB_NFU_ENABLE_NO_S2: {NFU_2_TO_ABB_NFU_ENABLE_NO_S2}, " +
               $"NFU_2_TO_WARTSILA_NFU_ENABLE_NC_S2: {NFU_2_TO_WARTSILA_NFU_ENABLE_NC_S2}, " +
               $"NFU_2_TO_WARTSILA_NFU_CW_S5: {NFU_2_TO_WARTSILA_NFU_CW_S5}, " +
               $"NFU_2_TO_WARTSILA_NFU_CCW_S6: {NFU_2_TO_WARTSILA_NFU_CCW_S6}";
    }
}
