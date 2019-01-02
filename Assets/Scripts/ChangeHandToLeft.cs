using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHandToLeft : MonoBehaviour
{

    public Sprite LeftDefault;
    public Sprite LeftMain;
    public Sprite RightDefault;
    public Sprite RightMain;
    public GameObject LeftHand;


    public void SetHighlightedLeft()
    {

        gameObject.GetComponent<Image>().sprite = RightDefault;
        LeftHand.GetComponent<Image>().sprite = LeftMain;

    }


}
