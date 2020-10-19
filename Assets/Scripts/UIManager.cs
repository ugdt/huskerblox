using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text timeField = null;

    // Start is called before the first frame update
    void Start()
    {
        if (timeField == null)
            Debug.LogError("Time field is null!");
    }

    private void Update()
    {
        UpdateTime(GameManager.Instance.Time);
    }

    private void UpdateTime(uint seconds)
    {
        
        timeField.text = $"{seconds / 60}:{seconds % 60}";
    }


}
