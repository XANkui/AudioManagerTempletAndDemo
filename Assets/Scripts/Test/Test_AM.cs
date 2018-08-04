using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 测试函数，测试 AudioManager 是否可用
/// </summary>
public class Test_AM : MonoBehaviour {

	// Use this for initialization
	void Start () {

        // 开始播放背景音乐 01
        AudioManager.Instance.PlayBGMusic(EnumResourcesPath.Audio_BGMusic.BGM_01);

    }

    // Update is called once per frame
    void Update () {

        // 按下 A 键播放背景音乐 01
        if (Input.GetKeyDown(KeyCode.A)) {
            AudioManager.Instance.PlayBGMusic(EnumResourcesPath.Audio_BGMusic.BGM_01);
        }

        // 按下 B 键播放背景音乐 02
        if (Input.GetKeyDown(KeyCode.B))
        {
            AudioManager.Instance.PlayBGMusic(EnumResourcesPath.Audio_BGMusic.BGM_02);
        }

        // 按下 C 键重新播放背景音乐 02
        if (Input.GetKeyDown(KeyCode.C))
        {
            AudioManager.Instance.PlayBGMusic(EnumResourcesPath.Audio_BGMusic.BGM_02, true);
        }

        // 按下 D 键播放特效音乐 FX_Bomb
        if (Input.GetKeyDown(KeyCode.D))
        {
            AudioManager.Instance.PlayFXMusic(EnumResourcesPath.Audio_FXMusic.FX_Bomb);
        }

        // 按下 E 键播放特效音乐 FX_Shoot，音量为 0.5
        if (Input.GetKeyDown(KeyCode.E))
        {
            AudioManager.Instance.PlayFXMusic(EnumResourcesPath.Audio_FXMusic.FX_Shoot, 0.5f);
        }

        // 按下 F 键播放其他音乐 ClickButton
        if (Input.GetKeyDown(KeyCode.F))
        {
            AudioManager.Instance.PlayOtherMusic(EnumResourcesPath.Audio_OtherMusic.ClickButton);
        }

        // 按下 G 键播放其他音乐 ClickButton，音量为 0.5
        if (Input.GetKeyDown(KeyCode.G))
        {
            AudioManager.Instance.PlayOtherMusic(EnumResourcesPath.Audio_OtherMusic.ClickButton, 0.5f);
        }
    }
}
