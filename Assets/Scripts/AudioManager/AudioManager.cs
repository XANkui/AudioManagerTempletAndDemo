using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton_XAN;

/// <summary>
/// 音频管理器，统一管理 背景乐 特效音乐 其他音乐 的播放
/// 使用方法：无需挂载，直接单例使用即可
/// </summary>
public class AudioManager : SingletonMonoBahaviourBase<AudioManager> {

    /// <summary>
    /// 背景音乐音量参数属性
    /// 可获得，可设置
    /// </summary>
    public float audSrc_BgMusic_Volume {
        get {
            return audSrc_BGMusic.volume;
        }
        set {
            audSrc_BGMusic.volume = value;
        }
    }

    /// <summary>
    /// 特效或其他音乐音量参数属性
    /// 可获得，可设置
    /// </summary>
    public float audSrc_FXorOther_Volume {
        get {
            return audSrc_FXorOther.volume;
        }
        set {
            audSrc_FXorOther.volume = value;
        }
    }

    /// <summary>
    /// 重构一个有具体枚举参数的背景音乐播放函数
    /// 是为了外部调用时，参数输入有可选性下拉菜单显示，便于操作
    /// </summary>
    /// <param name="BGMusic">背景音乐枚举值</param>
    /// <param name="isRestart">是否重新播放</param>
    public void PlayBGMusic(EnumResourcesPath.Audio_BGMusic BGMusic, bool isRestart = false) {

        PlayBGMusicByObject(BGMusic, isRestart);
    }

    /// <summary>
    /// 重构一个有具体枚举参数的特效音乐播放函数
    /// 是为了外部调用时，参数输入有可选性下拉菜单显示，便于操作
    /// </summary>
    /// <param name="FXMusic">特效音乐</param>
    /// <param name="volume">音量</param>
    public void PlayFXMusic(EnumResourcesPath.Audio_FXMusic FXMusic, float volume = 1.0f) {

        PlayFXorOtherMusicByObject(FXMusic, volume, true);
    }

    /// <summary>
    /// 重构一个有具体枚举参数的其他音乐播放函数
    /// 是为了外部调用时，参数输入有可选性下拉菜单显示，便于操作
    /// </summary>
    /// <param name="OtherMusic">其他音乐</param>
    /// <param name="volume">音量</param>
    public void PlayOtherMusic(EnumResourcesPath.Audio_OtherMusic OtherMusic, float volume = 1.0f)
    {
        PlayFXorOtherMusicByObject(OtherMusic, volume, false);
    }

    /// <summary>
    /// 播放背景音乐函数，声音文件参数枚举类型任意
    /// </summary>
    /// <param name="objectName">声音文件枚举值</param>
    /// <param name="isRestart">是否重新播放背景音乐</param>
    private void PlayBGMusicByObject(object objectName, bool isRestart = false) {

        // 设置当前音频名字参数，并置为空
        // 判断当前是否有背景音乐音频，有则赋值给当前音频名字参数
        string currentClipName = string.Empty;
        if (audSrc_BGMusic.clip != null) {
            currentClipName = audSrc_BGMusic.clip.name;
        }

        // 使用资源加载工具加载对应的音频文件
        AudioClip clip = ResourcesTool.Instance.ResourcesLoad<AudioClip>(objectName);

        // 当资源加载返回为空时，直接返回
        if (clip == null) {

            Debug.Log("加载失败，请确认是否存在此文件！");
            return;
        }

        // 当前播放的音频文件与加载文件一致，且没设置重新播放，则返回
        if (currentClipName == clip.name && isRestart == false) {

            Debug.Log("同一文件，且没有设置重新播放。");
            return;
        }

        // 把当前的背景音乐设置为加载的背景音乐，并开始播放
        audSrc_BGMusic.clip = clip;
        audSrc_BGMusic.Play();
    }

    /// <summary>
    /// 播放特效或其他音频函数，声音文件参数枚举类型任意
    /// </summary>
    /// <param name="objectName">声音文件枚举值</param>
    /// <param name="isFX">是否是特效音乐，区分特效与其他</param>
    /// <param name="volume">声音音量值</param>
    private void PlayFXorOtherMusicByObject(object objectName, float volume = 1.0f, bool isFX = true) {

        // 使用资源加载工具加载对应的音频文件
        AudioClip clip = ResourcesTool.Instance.ResourcesLoad<AudioClip>(objectName);

        // 当资源加载返回为空时，直接返回
        if (clip == null)
        {

            Debug.Log("加载失败，请确认是否存在此文件！");
            return;
        }

        // 当加载的是特效音乐时
        if (isFX == true)
        {
            // 以设定的音量值播放一次
            audSrc_FXorOther.PlayOneShot(clip, volume);
        }
        else {      // 当播放的不是特效音乐时  

            // 在 主相机的位置，以设置的音量值播放音频
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }

    protected override void Awake()
    {
        // 执行基类的代码
        base.Awake();

        // 给背景音乐音源添加 AudioSource 组件，并设置循环播放，和自动播放
        audSrc_BGMusic = this.gameObject.AddComponent<AudioSource>();
        audSrc_BGMusic.loop = true;
        audSrc_BGMusic.playOnAwake = true;

        // 给特效或其他音乐音源添加 AudioSource 组件，并设置为不循环播放，和不自动播放 
        audSrc_FXorOther = this.gameObject.AddComponent<AudioSource>();
        audSrc_FXorOther.loop = false;
        audSrc_FXorOther.playOnAwake = false;
    }

    private AudioSource audSrc_BGMusic;             // 背景音乐音源参数
    private AudioSource audSrc_FXorOther;           // 特效或其他音乐音源参数

}
