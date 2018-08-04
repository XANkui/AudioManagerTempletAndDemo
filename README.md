# AudioManagerTempletAndDemo
音频管理模板（内置Demo）

特点说明：

1、根据 Enum 管理音频资源文件目录；

2、分为背景音乐、特效音乐和其他音乐播放；

3、无需挂载音频管理脚本，直接对应播放对应音频即可，后台处理资源加载；

使用说明：

1、对应按类别把音频文件放到 Unity 工程的 Resoureces 文件夹下；

2、对应在 EnumResourecesPath 添加对应的音频枚举值；

3、在 ResourecesTool 对应添加修改 Switch Case 音频资源路径；

4、在需要的地方使用对应单例 AudioManager.Instance.PlayXXXMusic(EnumValue,...) 调用即可播放音频;
