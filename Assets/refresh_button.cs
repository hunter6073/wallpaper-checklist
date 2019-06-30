using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class refresh_button : MonoBehaviour {
    ArrayList list = new ArrayList();
    public Text txt;
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
        txt.text = null;
        list = new ArrayList();
        readchecklist();
    }
    void readchecklist()
    {
        // read into list
      
        FileStream fs = new FileStream("./checklist.txt", FileMode.OpenOrCreate, FileAccess.Read);
        StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default); // read txt into file

        string line;
        while ((line = sr.ReadLine()) != null)
        {
            if (line != "" && line != null)
            {
                list.Add(line);
            }
        }

        sr.Close();
        fs.Close();
        Transform s = this.transform;
        string stemp = "";
        for (int i = 0; i < list.Count; i++) // get from list and put into ui
        {
            stemp = stemp+(i + 1) + ". " + list[i] + "\n";
        }
        txt.text = stemp;
    }
}
