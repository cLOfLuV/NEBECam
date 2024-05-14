using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;
using System.Collections; 

public class NameInputManager : MonoBehaviour
{
    public InputField playerNameInputField; 
    public Button joinButton; 
    public GameObject Player;
    public GameObject warningText;

    public GameObject characterInstance;
    public GameObject Name1;
    private NameTag NameTag;

    private void Start()
    {
       
        joinButton.onClick.AddListener(OnJoinClicked);
     

    }


    private void OnJoinClicked()
    {
        string playerName = playerNameInputField.text; 

        if (IsNameValid(playerName))
        {
            
          
            playerNameInputField.gameObject.SetActive(false);
            joinButton.gameObject.SetActive(false);

            NameTag.SetName(playerName);
            Player.SetActive(true);
        }
        else
        {
            warningText.SetActive(true);
            StartCoroutine(Reinvoke());

        }
    }

    IEnumerator Reinvoke()
    {
        yield return new WaitForSeconds(4f);
        warningText.SetActive(false); 
        OnJoinClicked(); 
    }

    private bool IsNameValid(string playerName)
    {
        return playerName.Length > 1 && playerName.Length < 10;
    }
    
}