using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Best Score: " + Score.bestScore.ToString();
    }
}
