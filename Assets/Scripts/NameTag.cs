using UnityEngine;
using UnityEngine.UI;

public class NameTag : MonoBehaviour
{
    public Text Name1; 

    
    public void SetName(string playerName)
    {
        Name1.text = playerName;
    }
}