using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 
    }

    public Text _text;
    // Update is called once per frame
    void Update()
    {
        int curCount = DataCenter.GetInstance().GetCount();
        //Text 유아이에 출력

        _text.text = "curCount: " + curCount.ToString();
    }

}
