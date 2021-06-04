using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InMenuMgr : MonoBehaviour
{
    public Button btnNext;

    // Start is called before the first frame update
    void Start()
    {
        btnNext.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClick()
    {
        Debug.Log("aaaa");
    }
}
