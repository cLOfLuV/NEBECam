using UnityEngine;
using UnityEngine.UI;

public class FollowCamera : MonoBehaviour
{
    public Camera mainCamera;
    public Text text; 

    void LateUpdate()
    {
       
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);

       
        Vector3 worldCenter = mainCamera.ScreenToWorldPoint(screenCenter);

        
        text.transform.position = worldCenter;

    }
}