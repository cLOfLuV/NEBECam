using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameButton : MonoBehaviour
{

    public GameObject Name1;

    public void ViewNameBoard()
    {
        bool isActive = Name1.active;
        Name1.SetActive(!isActive);
    }
}
