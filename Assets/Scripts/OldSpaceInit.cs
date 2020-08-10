using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldSpaceInit : MonoBehaviour {

    public GameObject boxObjPrefab;
    public GameObject boxesObj;

    void Awake() {
        for (int x = 0; x < 10; x++) {
            float X = Random.Range (-2.5f, 2.5f);
            float Y = Random.Range (-1.0f, 1.0f);
            float Z = Random.Range (-2.5f, 2.5f);
            GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
            g.transform.position = new Vector3(X, Y, Z);
        }
    }

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
}
