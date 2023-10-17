using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveChild : MonoBehaviour
{
    public int ID;
    public GameManager gm;
    public GameObject canvas;
    // Start is called before the first frame update
    
    //마커가 인식 되었을 때
    public void ActiveMark()
    {
        if (ID == gm.randomNumber)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            canvas.transform.GetChild(0).gameObject.SetActive(true);
            Debug.Log("ID: " + ID + "여기는 아닌 것 같다...");
        }
    }
    public void RemoveMark()
    {
        if (ID == gm.randomNumber)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            canvas.transform.GetChild(0).gameObject.SetActive(false);
            //UI: 여긴 아닌거 같다... 삭제
        }
    }
}
