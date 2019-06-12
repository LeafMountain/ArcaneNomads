using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolUser : MonoBehaviour
{
    public Tool tool;
    public Transform attachPoint;

    Tool currentTool;
    bool aiming;
    Transform cam;

    public void UseTool()
    {
        currentTool?.Use(this);
    }

    public void Equip(ITool tool)
    {
        if (currentTool != null) Destroy(currentTool);
        this.tool = (Tool)tool;

        currentTool = (Tool)tool;

        if (attachPoint)
        {
            currentTool.transform.position = attachPoint.position;
            currentTool.transform.rotation = attachPoint.rotation;
            currentTool.transform.parent = attachPoint;
        }
        else Debug.LogError("Attach point missing.");

        GetComponent<Animator>().SetBool("MediumStockEquipped", currentTool);
    }

    public void Aim(bool value)
    {
        aiming = value;
        GetComponent<Animator>()?.SetBool("Aiming", value);
    }

    void Start()
    {
        cam = Camera.main.transform;

        if (!currentTool)
        {
            Equip(Instantiate(tool).GetComponent<Tool>());
        }
    }

    void Update()
    {
        if (aiming)
        {
            RaycastHit hit;
            if (Physics.Raycast(cam.position, cam.forward, out hit))
            {
                currentTool.transform.LookAt(hit.point);
            }
            else
                currentTool.transform.forward = (cam.forward);
        }
    }
}
