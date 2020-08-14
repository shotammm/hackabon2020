using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OldSpaceInit : MonoBehaviour {

    public GameObject boxObjPrefab;
    public GameObject boxesObj;
    public static int oldSpaceNum = 20;
    public float nowTime;
    private float timeleft;
    public static int stage1 = 20;
    public static int stage2 = 20;
    public static int count = 0;


    void Awake() {
        // GameObject masterObj = GameObject.Find("Master");
        for (int x = 0; x < oldSpaceNum; x++) {
            float X = Random.Range (-2.5f, 2.5f);
            float Y = Random.Range (-1.0f, 1.0f);
            float Z = Random.Range (0f, 2.5f);
            float S = Random.Range (0.05f, 0.2f);
            GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
            g.transform.position = new Vector3(X, Y, Z);
            g.transform.localScale = new Vector3(S, S, S);
            // g.GetComponent<Destroyer>().masterObj = masterObj;
        }
    }


    // Use this for initialization
    void Start () {
        nowTime = 0;
    }


    void Update() {
        for (int i = 0; i < stage1; i++) {
            if (count<20) {
                //だいたい1秒ごとに処理を行う
                timeleft -= Time.deltaTime;
                if (timeleft <= 0.0) {
                    timeleft = 20.0f;
                    //ここに処理
                    float X = Random.Range (-2.5f, 2.5f);
                    float Y = Random.Range (-1.0f, 1.0f);
                    float Z = Random.Range (0f, 2.5f);
                    float S = Random.Range (0.05f, 0.2f);
                    GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
                    g.transform.position = new Vector3(X, Y, Z);
                    g.transform.localScale = new Vector3(S, S, S);

                    count++;
                    }
            }
            else {
              //だいたい1秒ごとに処理を行う
              timeleft -= Time.deltaTime;
              if (timeleft <= 0.0) {
                  timeleft = 15.0f;
                  //ここに処理
                  float X = Random.Range (-2.5f, 2.5f);
                  float Y = Random.Range (-1.0f, 1.0f);
                  float Z = Random.Range (0f, 2.5f);
                  float S = Random.Range (0.2f, 0.4f);
                  GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
                  g.transform.position = new Vector3(X, Y, Z);
                  g.transform.localScale = new Vector3(S, S, S);
            }
        }

    }

    // Update is called once per frame
    // void Update () {
    //     nowTime += Time.deltaTime;
    //     if (oldSpaceNum <= 0) {
    //         GameOver("CONGRATULATIONS! \n YOU CLEARED IN " + nowTime.ToString("F0") + " SECONDS");  //<=====秒数をstring型にキャストして引数へ
    //     }
    // }

    // public void GameOver(string resultMessage) {   //<=====引数をもたせた
    //     DataSender.resultMessage = resultMessage;  //<=====受け取った引数をstatic変数へ格納
    //     SceneManager.LoadScene("Result");
    // }
}
}
