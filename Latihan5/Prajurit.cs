using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prajurit : Manusia
{
	public void serang(){
		Debug.Log("Menyerang");}
	
    // Start is called before the first frame update
    void Start()
    {
		Debug.Log("Seorang Perajurit dapat : ");
		serang();
		makan();
		tidur();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
