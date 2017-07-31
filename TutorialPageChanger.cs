using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AppTour {
	public class TutorialPageChanger : MonoBehaviour {
	    //Add pages from editor
	    public GameObject[] pages;
	    int pageNumber;

		void Awake () {

	        ChangePage();

		}

	    public void NextPage() {
	        if (pageNumber < pages.Length-1) {
	            pageNumber++;
	            ChangePage();
	        }
	    }

	    public void PrevPage() {

	        if (pageNumber > 0) {
	            pageNumber--;
	            ChangePage();
	        }
	    }

	    void ChangePage() {

	        foreach (GameObject page in pages)
	        {

	            page.SetActive(false);

	        }

	        if (pages != null && pages[0] != null)
	            pages[pageNumber].SetActive(true);


	    }
	}
}