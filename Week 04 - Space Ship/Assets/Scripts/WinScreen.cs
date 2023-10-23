using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private float startTime;
    [SerializeField] private float currentTime;
    [SerializeField] private GameObject winPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if(currentTime <= 0.0f)
        {
            Win();
        }
    }

    public void Win()
    {
        winPanel.SetActive(true);
    }
}