using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AppTour {
	public class HelpElement : MonoBehaviour {
	    
		public string group;

	    //used in HelpManager for sorting
		public int priority;

	    public GameObject parentElement;

	    public Text text;

		// Use this for initialization
		void Awake () {
	        text = GetComponent<Text>();
		}
	    
	}
}