using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupScript : MonoBehaviour
{
    public GameObject Nomalpopup;
    public GameObject Hardpopup;
    public GameObject Storypopup;

    public void NomalAppear()
    {
        Nomalpopup.SetActive(true);
    }
    public void HardApper()
    {
        Hardpopup.SetActive(true);
    }
    public void StoryApper()
    {
        Storypopup.SetActive(true);
    }

    public void Delete()
    {
        Nomalpopup.SetActive(false);
        Hardpopup.SetActive(false);
        Storypopup.SetActive(false);
    }
}
