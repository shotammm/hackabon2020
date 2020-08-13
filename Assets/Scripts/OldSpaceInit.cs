using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OldSpaceInit : MonoBehaviour {

    public GameObject boxObjPrefab;
    public GameObject boxesObj;
    public static int oldSpaceNum = 20;
    public float nowTime;

    void Awake() {
        // GameObject masterObj = GameObject.Find("Master");
        for (int x = 0; x < oldSpaceNum; x++) {
            float X = Random.Range (-2.5f, 2.5f);
            float Y = Random.Range (-1.0f, 1.0f);
            float Z = Random.Range (-2.5f, 2.5f);
            GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
            g.transform.position = new Vector3(X, Y, Z);
            // g.GetComponent<Destroyer>().masterObj = masterObj;
        }
    }

    // Use this for initialization
    void Start () {
        nowTime = 0;
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
