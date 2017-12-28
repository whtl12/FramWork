using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour {

    Stack PopupStack = new Stack();

	// Use this for initialization
	void Start () {
        

    }
	
    public void ClosePopup()
    {
        GameObject gameObj = PopupStack.Pop() as GameObject;
        gameObj.SetActive(false);
    }

    public void OpenPopup(Object obj, bool lastPopupClosing = false)
    {
        if (obj == null)
            return;

        GameObject gameObj = obj as GameObject;

        if (lastPopupClosing && PopupStack.Count > 0)
        {
            GameObject lastgameObj =  PopupStack.Pop() as GameObject;
            lastgameObj.SetActive(false);
        }

        gameObj.SetActive(true);
        PopupStack.Push(obj);
    }

    public void AllClosePopup()
    {
        while(PopupStack.Count > 0)
        {
            GameObject gameObj = PopupStack.Pop() as GameObject;
            gameObj.SetActive(false);
        }
    }


}
