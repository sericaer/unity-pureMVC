using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour 
{
    public static Demo Inst;
    private void Awake()
    {
        Inst = this;
    }

    // Use this for initialization
    void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    internal static void Update(Notification notify)
    {
        Inst.GetComponent<Text>().text = notify.name;
    }
}
