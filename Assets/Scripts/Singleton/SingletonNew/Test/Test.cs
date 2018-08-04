using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 继承 MonoBehavior 的类，用于挂在测试使用
/// </summary>
public class Test : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        // 按下 A 键测试单例，调用单例函数
        if (Input.GetKeyDown(KeyCode.A)) {

            SingletonNewTest.Instance.FunTest();
        }
	}


}
