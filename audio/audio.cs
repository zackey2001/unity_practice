using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//このスクリプトがつけられているゲームオブジェクトにAudioSourceコンポーネントをつける。
[RequireComponent(typeof(AudioSource))]

public class audio : MonoBehaviour
{
    //オーディオソースコンポーネントは、現実世界ではCDプレイヤー
    private AudioSource audioSource;

    //オーディオクリップは、現実世界ではCD
    public AudioClip clip;

    void Start()
    {
        //ゲームオブジェクトからオーディオソースコンポーネントを取得して、aduioSource経由で使えるようにする
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //左クリックされたら、音を鳴らす処理
        if (Input.GetButton("Fire1"))
        {
            //オーディオソースにオーディオクリップをセットする
            audioSource.clip = clip;

            //再生する
            audioSource.Play();
        }
        
    }
}
