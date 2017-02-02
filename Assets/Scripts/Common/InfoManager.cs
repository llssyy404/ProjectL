using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConstNameSpace;

public class InfoManager : MonoBehaviour {

    private static InfoManager _instance;
    public static InfoManager GetInstance()
    {
        if (null == _instance)
        {
            GameObject InfoObj = new GameObject();
            var InfoManager = InfoObj.AddComponent<InfoManager>();
            _instance = InfoManager;
            InfoManager.Init();
            InfoManager.name = "InfoManager";

        }
        return _instance;
    }

    void Init()
    {
    }
}
