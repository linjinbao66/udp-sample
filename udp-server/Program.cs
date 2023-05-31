using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

class Program
{
    static void Main()
    {
        // 目标主机的IP地址和端口号
        string ipAddress = "127.0.0.1";
        int udpPort = 2234;

        // 创建UDP监听器
        UdpClient udpClient = new UdpClient();

       GetPData2 data = new GetPData2()
            {
                Handle_L_Pin2 = 1.2,
                Handle_L_Pin4 = 3.4,
            };

        // 将GetPData2对象转换为JSON字符串
        string jsonData = JsonSerializer.Serialize(data);

        // 将JSON字符串转换为字节数组
        byte[] sendBytes = Encoding.UTF8.GetBytes(jsonData);
        try
        {
            // 发送UDP数据
            udpClient.Send(sendBytes, sendBytes.Length, ipAddress, udpPort);

            Console.WriteLine("数据已发送成功");
        }
        catch (Exception ex)
        {
            Console.WriteLine("发送UDP数据时出现错误：" + ex.Message);
        }
        finally
        {
            // 关闭UdpClient对象
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
