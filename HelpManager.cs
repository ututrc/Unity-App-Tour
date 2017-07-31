using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AppTour {
	public class HelpManager : MonoBehaviour {

	    //Set content of Help panel in editor
	    public HelpPanel uiContent;

	    HelpElement[] helpElements;
	    HelpElement currentElement;

	    //Set help arrow in editor
	    public RectTransform arrow;

	    bool isOn;
	    int count;
	    
	    void Start () {
	        uiContent.gameObject.SetActive(false);
	    }

	    public void SwitchTutorial() {

	        if (!isOn) {
	            
	            isOn = GetCurrenHelps();
	        }
	        else {
	            arrow.parent = uiContent.transform;
	            uiContent.gameObject.SetActive(false);
	            isOn = false;
	        }
	    }
	    
	    //Gets all active help elements
	    public bool GetCurrenHelps() {
	    
	        helpElements = FindObjectsOfType<HelpElement>();

	        if (helpElements != null && helpElements.Length>0){

	            Array.Sort(helpElements, (a, b) => a.priority.CompareTo(b.priority));

	            count = 0; 
	            currentElement = helpElements[count];
	            uiContent.gameObject.SetActive(true);
	            SetArrowToCurrentElement();
	            uiContent.ShowTutorialText(currentElement.text.text);
	            return true;
	        }
	        arrow.parent = uiContent.transform;
	        uiContent.gameObject.SetActive(false);
	        return false;
	    }

	    void SetArrowToCurrentElement() {
	        
	        arrow.SetParent(currentElement.GetComponent<RectTransform>(), false);
	        arrow.localPosition = new Vector3(0, 0, 0);
	        arrow.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
	    }

	    
	    //Set buttons to change current help element
	    public void NextElement() {

	        if (!isOn)
	            return;
	        if (helpElements.Length-1 > count)
	            count++;
	        else
	            count = 0;
	        currentElement = helpElements[count];
	        uiContent.ShowTutorialText(currentElement.text.text);
	        SetArrowToCurrentElement();
	    }

	    public void PrevElement() {

	        if (!isOn)
	            return;
	        if (count > 0)
	            count--;
	        else
	            count = helpElements.Length-1;
	        currentElement = helpElements[count];
	        uiContent.ShowTutorialText(currentElement.text.text);
	        SetArrowToCurrentElement();
	    }
	}
}
