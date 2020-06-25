using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//プレイヤーのクラス
public class Player : MonoBehaviour
{
    //メンバ***************************
    private int HP; //HPは誰かに操作されると困る・・・困りませんか？？

    //コンストラクタ
    public Player()
    {
        HP = 10;    //HPを10に設定
    }

    //デストラクタ
    ~Player()
    {
        //処理なし
    }

    //メソッド***************************

    //HPをゲットする
    public int GetHP()
    {
        return this.HP; //HPを返す
    }

    //HPを減らすする
    public void MinusHP(int DownValue)
    {
        this.HP -= DownValue; //HPを減算する
    }
}