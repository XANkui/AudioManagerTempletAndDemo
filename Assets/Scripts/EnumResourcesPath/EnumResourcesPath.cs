using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 所需要加载资源的资源路径枚举列表目录
/// 注：可以与对应的 ResourcesTool 加载工具放在一个脚本
/// </summary>
public class EnumResourcesPath  {

    /// <summary>
    /// Resources 目录下的 Audio_BGMusic 资源加载文件名目录
    /// </summary>
    public enum Audio_BGMusic {

        BGM_01,               // 设置名称与资源名称一致
        BGM_02,
    }

    /// <summary>
    /// Resources 目录下的 Audio_FXMusic 资源加载文件名目录
    /// </summary>
    public enum Audio_FXMusic {

        FX_Bomb,             // 设置名称与资源名称一致
        FX_Get_01,
        FX_Get_02,
        FX_GoldCoin,
        FX_Shoot,
        FX_SilverCoin,
    }

    /// <summary>
    /// Resources 目录下的 Audio_OtherMusic 资源加载文件名目录
    /// </summary>
    public enum Audio_OtherMusic
    {

        ClickButton,               // 设置名称与资源名称一致
        
    }
}
