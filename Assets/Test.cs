using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //配列を初期化する
        int[] array = { 1, 3, 5, 7, 9 };
        //配列を初めからコンソールに表示
        Debug.Log(array[0]);
        Debug.Log(array[1]);
        Debug.Log(array[2]);
        Debug.Log(array[3]);
        Debug.Log(array[4]);
        //配列をforを使い、逆順にコンソールに表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
