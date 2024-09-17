using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SprintBar : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    private Image sprintBar;
    // Start is called before the first frame update
    void Start()
    {
        sprintBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        sprintBar.fillAmount = playerMovement.stamina / 100f;
    }
}
