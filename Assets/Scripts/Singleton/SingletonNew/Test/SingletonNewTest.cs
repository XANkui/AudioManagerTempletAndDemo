using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton_XAN;

/// <summary>
/// 继承泛型 new 单例模版
/// </summary>
public class SingletonNewTest : SingletonNewBase<SingletonNewTest>
{
    /// <summary>
    /// 用于测试泛型 new 单例模板的测试函数
    /// </summary>
    public void FunTest() {

        // 控制台打印
        Debug.Log("这是一个继承可 new 的泛型单例模版测试函数！");
    }
}

