using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private uint time = 0;
    
    private UIManager uiManager = null;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = GetComponent<UIManager>();
        InvokeRepeating("DecrementTime", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DecrementTime()
    {
        time -= 1;
        Debug.Log(time);
        uiManager.UpdateTime(time);
        if (time == 0)
            CancelInvoke("DecrementTime");
    }
}
