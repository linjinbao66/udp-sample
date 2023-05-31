using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        // 监听的本地端口号
        int localPort = 2234;

        // 创建UdpClient对象，并绑定到本地端口
        UdpClient udpListener = new UdpClient(localPort);

        try
        {
            Console.WriteLine("UDP接口已启动，等待数据...");

            while (true)
            {
                // 接收UDP数据
                IPEndPoint remoteEP = null;
                byte[] receiveBytes = udpListener.Receive(ref remoteEP);

                // 将接收到的字节数组转换为字符串
                string message = Encoding.UTF8.GetString(receiveBytes);

                Console.WriteLine($"接收到来自 {remoteEP.Address}:{remoteEP.Port} 的数据");
                var jsonObject = System.Text.Json.JsonSerializer.Deserialize<GetPData2>(message);
                if (jsonObject != null)
                {
                    Console.WriteLine("GetPData2: " + jsonObject.ToString());
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("接收UDP数据时出现错误：" + ex.Message);
        }
        finally
        {
            // 关闭UdpClient对象
            udpListener.Close();
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
