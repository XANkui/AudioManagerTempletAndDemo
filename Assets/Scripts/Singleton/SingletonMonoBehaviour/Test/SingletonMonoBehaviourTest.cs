using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton_XAN;

/// <summary>
/// 继承泛型 MonoBehaviour 单例模版
/// </summary>
public class SingletonMonoBehaviourTest : SingletonMonoBahaviourBase<SingletonMonoBehaviourTest> {

    /// <summary>
    /// 用于测试泛型 MonoBehaviour 单例模板的测试函数
    /// </summary>
    public void FunTest()
    {

        // 控制台打印
        Debug.Log("这是一个继承可 MonoBehaviour 的泛型单例模版测试函数！");
    }
}
