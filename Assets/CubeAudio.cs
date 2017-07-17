using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//衝突判定を行い、衝突したものがCubeもしくはGroundの場合、音を鳴らす。　というスクリプトを作成する

//if文もしくはbool型を使用する

//if文で作成（bool型はいろいろ試すも、うまいこといかず。。）
   
public class CubeAudio : MonoBehaviour {
    
    private AudioSource sound;

    public GameObject cubePrefab;

    public GameObject Ground;

    void OnCollisionEnter2D(Collision2D other)
    {
        sound = GetComponent<AudioSource>();
        if(other.gameObject.tag == "GroundTag") 
        {
            sound.Play();
        }
        if(other.gameObject.tag == "CubePrefab")
        {
            sound.Play();
        }
    }
}
