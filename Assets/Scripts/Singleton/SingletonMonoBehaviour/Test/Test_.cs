using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 继承 MonoBehavior 的类，用于挂在测试使用
/// </summary>
public class Test_ : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // 按下 B 键，调用 MonoBehavior 单例测试函数
        if (Input.GetKeyDown(KeyCode.B)) {
            SingletonMonoBehaviourTest.Instance.FunTest();
        }
	}
}
