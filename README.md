SkHalconService是一个分布式的Halcon服务。
它可以使用SOA方式使用halcon的算子。主要目的是在一个内网中多个客户端可以并发访问Halcon服务。
目前此项目处于开发启动阶段。（2024.7.1)

（一）分布式halcon服务的特点：

1. 多段式设备，一般配置多台电脑处理不同工位的视觉，这样每台电脑都得装一份halcon。
      分布式halcon服务只需要一份halcon授权，节省金钱。
2. 服务端负责内存管理，客户端不再有内存泄露的烦恼
3. 客户端不需要安装halcon环境，只需要调用分布式halcon服务的api，极大简化了客户端的代码复杂度。
4. 客户端可以有多个，并且运行在不同的设备、不同的操作系统下（即客户端可以跨网络、跨电脑、跨设备），客户端可以并发调用分布式halcon服务。
5. 分布式halcon服务可以支持两种工作模式：
     一是RPC模式，它是请求应答方式进行api调用。
     二是BAT模式，即脚本批处理方式，客户调把脚本发往服务端，脚本执行过程完全是在服务端，执行完成后回复处理结果给客户端。
6. 分布式halcon服务可以支持集群，通过添加新的IPC来增强处理能力。


（二）分布式halcon服务的应用场景

适合使用halcon平台，低速、传统算法视觉处理应用的设备开发。
适合教学与实验的需求。

