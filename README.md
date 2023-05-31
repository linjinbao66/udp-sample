# 项目说明

1. 项目会启动2个服务，一个是数据接收(udp-receiver)，一个是数据发送(udp-server)
2. 服务使用dotnet sdk6.0

## 使用步骤

1. cd udp-receiver 
2. dotnet build && dotnet run 


* 重新开启一个终端
1. cd udp-server
2. dotnet build && dotnet run


在`udp-receiver`的终端窗口输出如下：
```code
UDP接口已启动，等待数据...
接收到来自 127.0.0.1:52621 的数据
GetPData2: Handle_L_Pin2: 1.2, Handle_L_Pin4: 3.4, Handle_L_Pin7: 0, Handle_R_Pin2: 0, Handle_R_Pin4: 0, Handle_R_Pin7: 0, Handle_1_Pin1: 0, Handle_1_Pin3: 0, Handle_2_Pin1: 0, Handle_2_Pin3: 0, NFU_1_POWER_FAILURE_ALARM: False, NFU_1_TO_ABB_RPM_INC_S3: False, NFU_1_TO_ABB_RPM_DEC_S4: False, NFU_1_TO_ABB_NFU_ENABLE_NO_S2: False, NFU_1_TO_WARTSILA_NFU_ENABLE_NC_S2: False, NFU_1_TO_WARTSILA_NFU_CW_S5: False, NFU_1_TO_WARTSILA_NFU_CCW_S6: False, NFU_2_POWER_FAILURE_ALARM: False, NFU_2_TO_ABB_RPM_INC_S3: False, NFU_2_TO_ABB_RPM_DEC_S4: False, NFU_2_TO_ABB_NFU_ENABLE_NO_S2: False, NFU_2_TO_WARTSILA_NFU_ENABLE_NC_S2: False, NFU_2_TO_WARTSILA_NFU_CW_S5: False, NFU_2_TO_WARTSILA_NFU_CCW_S6: False
```