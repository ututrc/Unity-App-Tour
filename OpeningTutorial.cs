using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AppTour {
	public class OpeningTutorial : MonoBehaviour {

	    //Set content in editor
	    public GameObject openingTutorialContent;
	    
		void Awake () {
	        openingTutorialContent.SetActive(false);
		}
		

	    //Set open and close to buttons
	    public void OpenTutorial() {
	        openingTutorialContent.SetActive(true);
	    }

	    public void CloseTutorial()
	    {
	        openingTutorialContent.SetActive(false);
	    }
	}
}