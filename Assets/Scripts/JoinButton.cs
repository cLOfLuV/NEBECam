using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinButton : MonoBehaviour
{
    private string playerName;
    public InputField playerNameInput;
    public GameObject Name1;

  
    private void Start(string name1)
    {
        playerName = name1;
    }

    public void JoinGame()
    {
        if (playerName.Length > 1 && playerName.Length < 11)
        {
            
            
           GameManager.Instance.playerName = playerName;
        }

    }
}