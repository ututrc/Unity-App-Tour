using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AppTour {
	public class HelpPanel : MonoBehaviour {

	    public Text text;
	    
		void Start () {
		}

	    public void ShowTutorialText(string text)
	    {
	        this.text.text = text;
	    }
		
	}
}
