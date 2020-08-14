using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Destroyer : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler {

    private MeshRenderer m_MeshRender;
    public GameObject masterObj;
    public int score = 1;

    void Awake()
    {
        m_MeshRender = transform.GetComponent<MeshRenderer>();
    }

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    //when pointer hover, set the cube color to green
    public void OnPointerEnter(PointerEventData eventData)
    {
        m_MeshRender.material.color = Color.green;
    }

    //when pointer exit hover, set the cube color to white
    public void OnPointerExit(PointerEventData eventData)
    {
        m_MeshRender.material.color = Color.white;
    }

    public void OnPointerClick(PointerEventData eventData) {
        OldSpaceInit.oldSpaceNum--;
        score++;
        Destroy(gameObject);
    }
}
