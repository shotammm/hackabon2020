using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Destroyer : MonoBehaviour, IPointerClickHandler {

    private MeshRenderer m_MeshRender;
    public GameObject masterObj;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    public void OnPointerClick(PointerEventData eventData){
        OldSpaceInit.oldSpaceNum--;
        Destroy(gameObject);
    }
}
