using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton_XAN {

    /// <summary>
    /// 一个无需挂载，使用是自动挂载的继承MonoBehavior的单例基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingletonMonoBahaviourBase<T> : MonoBehaviour where T : SingletonMonoBahaviourBase<T> {

        /// <summary>
        /// 单例参数属性
        /// 若单例为空，则新建空物体挂载脚本
        /// 并在 Awake 函数中初始化
        /// </summary>
        public static T Instance {
            get {
                if (_instance == null) {
                    GameObject go = new GameObject(typeof(T).Name);
                    go.AddComponent<T>();
                }

                return _instance;
            }

        }

        /// <summary>
        /// 在 Awake 中初始化 _instance
        /// 子类可继承重写的虚函数 Awake 函数
        /// </summary>
        protected virtual void Awake()
        {
            _instance = this as T;      // 因为 this 在 Instance 静态属性中无法使用
        }

        private static T _instance;     // 单例参数
    }
}
