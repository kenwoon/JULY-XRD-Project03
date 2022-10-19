using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrganDetector : MonoBehaviour
{
    [SerializeField]
    private Image brainIcon, heartIcon, rightLungIcon, leftLungIcon, stomachIcon, bladderIcon, rightKidneyIcon, leftKidneyIcon;

    void Start()
    {
        brainIcon.color = new Color(1, 1, 1, 0.2f);
        heartIcon.color = new Color(1, 1, 1, 0.2f);
        rightLungIcon.color = new Color(1, 1, 1, 0.2f);
        leftLungIcon.color = new Color(1, 1, 1, 0.2f);
        stomachIcon.color = new Color(1, 1, 1, 0.2f);
        bladderIcon.color = new Color(1, 1, 1, 0.2f);
        rightKidneyIcon.color = new Color(1, 1, 1, 0.2f);
        leftKidneyIcon.color = new Color(1, 1, 1, 0.2f);
    }

    public void OnBrainFound()
    {
        brainIcon.color = new Color(1, 1, 1, 1);
    }

    public void OnHeartFound()
    {
        heartIcon.color = new Color(1, 1, 1, 1);
    }

    public void OnRightLungFound()
    {
        rightLungIcon.color = new Color(1, 1, 1, 1);
    }

    public void OnLeftLungFound()
    {
        leftLungIcon.color = new Color(1, 1, 1, 1);
    }

    public void OnStomachFound()
    {
        stomachIcon.color = new Color(1, 1, 1, 1);
    }

    public void OnBladderFound()
    {
        bladderIcon.color = new Color(1, 1, 1, 1);
    }

    public void OnRightKidneyFound()
    {
        rightKidneyIcon.color = new Color(1, 1, 1, 1);
    }

    public void OnLeftKidneyFound()
    {
        leftKidneyIcon.color = new Color(1, 1, 1, 1);
    }
}
