using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHandToRight : MonoBehaviour {

    public Sprite LeftDefault;
    public Sprite LeftMain;
    public Sprite RightDefault;
    public Sprite RightMain;
    public GameObject RightHand;


    public void SetHighlightedRight() 
    {

        gameObject.GetComponent<Image>().sprite = LeftDefault;
        RightHand.GetComponent<Image>().sprite = RightMain;

    }

    
}
