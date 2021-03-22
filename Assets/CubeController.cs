using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // キューブ衝突音を鳴らすためのコンポーネントを入れる
    public AudioClip cubeSound;

    void Start()
    {
        
    }

    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        // 画面外に出たら破棄する
        if(transform.position.x < this.deadLine){
            Destroy(gameObject);
        }
    }

    // キューブ衝突時のイベント
    void OnCollisionEnter2D(Collision2D collision){
        // 衝突したのがUnityちゃん以外の時にキューブの衝突音を鳴らす
        if(collision.gameObject.tag != "UnityChanTag"){
        AudioSource.PlayClipAtPoint(cubeSound, transform.position);
        }
    }
}
