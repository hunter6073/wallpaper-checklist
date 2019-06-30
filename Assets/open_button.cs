using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class open_button : MonoBehaviour {
    // Use this for initialization
    void Start () {
        Button button = gameObject.GetComponent<Button>() as Button;//获取Button组件
        button.onClick.AddListener(myClick);//为button的OnClick事件添加监听器，当监听到Click事件时，回调myClick函数。
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   public void myClick()
    {
        System.Diagnostics.Process.Start("notepad", "./checklist.txt");
    }
}
