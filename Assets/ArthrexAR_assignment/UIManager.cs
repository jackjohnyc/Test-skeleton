using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    // References to the gameobjects

    public GameObject ScanPanel;
    public GameObject MatBtn;
    public GameObject AutoRotateBtn;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void ToggleMaterial()
    {
        FindObjectOfType<SkeletonManager>().ToggleMaterial(); // Call toggle material function of SkeletonManager
    }

    public void ToggleAutoRotate()
    {
        FindObjectOfType<SkeletonManager>().ToggleAutoRotate(); // Call Toggle Auto Rotate function of SkeletonManager
    }

    public void CloseApplication()
    {
        Application.Quit();  // Exit application
    }

    // Disable scan panel and enable toggle material button and toggle rotation button

    public void TrackerFound()
    {
        ScanPanel.SetActive(false);
        MatBtn.SetActive(true);
        AutoRotateBtn.SetActive(true);
    }
}
