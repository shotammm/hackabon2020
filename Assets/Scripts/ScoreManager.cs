using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public GameObject score_object = null; // Textオブジェクト

      // 初期化
      void Start () {
      }

      // 更新
      void Update () {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text> ();
        Destroyer d = new Destroyer();
        int score = d.score;
        // テキストの表示を入れ替える
        score_text.text = "Score:" + score;

      }
}
