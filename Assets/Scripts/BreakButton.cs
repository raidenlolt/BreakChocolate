using UnityEngine;
using System.Collections;

public class BreakButton : MonoBehaviour
{
    public delegate void BreakAction();
    public static event BreakAction OnBreak;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Debug.Log("[BreakButton:OnMouseDown]");
        if (OnBreak != null)
            OnBreak();
    }
}
