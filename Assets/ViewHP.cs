using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;  //追加

public class ViewHP : MonoBehaviour
{
    //Textオブジェクト
    //Unityから、Inspector内で、Textをドラッグアンドドロップで追加すること
    public GameObject score_object = null;

    //ゲームオブジェクト
    //Unityから、Inspector内で、playerをドラッグアンドドロップで追加すること
    public GameObject game_object;

    //実際に表示するテキスト
    private Text score_text;

    //実際に取得するPlayerクラス
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        // オブジェクトからTextコンポーネントを取得
        score_text = score_object.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //マウスの左ボタンをクリックしたら・・
        if (Input.GetMouseButtonDown(0))
        {
            //Playerクラス取得
            player = game_object.GetComponent<Player>();

            if (player != null) //クラスが取得できたら
            {
                //HPを減らす
                player.MinusHP(1);
            }
        }

        //HPを表示する
        score_text.text = player.GetHP().ToString();
    }
}
