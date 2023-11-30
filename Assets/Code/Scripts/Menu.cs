using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI currency1UI;

    private void OnGUI()
    {
        currency1UI.text = LevelManager.main.currency1.ToString();
    }

    public void SetSelected()
    {

    }

}
