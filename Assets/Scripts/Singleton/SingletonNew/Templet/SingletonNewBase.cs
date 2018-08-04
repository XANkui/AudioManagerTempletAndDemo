using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton_XAN
{

    /// <summary>
    /// 一个继承即可实现 new 类型的泛型单例基类
    /// </summary>
    /// <typeparam name="T">泛型</typeparam>
    public class SingletonNewBase<T> where T : new()
    {

        // 公有泛型静态属性
        // 参数若为空，则进行 new 初始化
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new T();
                }

                return _instance;
            }
        }


        // 私有泛型静态参数
        private static T _instance;
    }
}
