using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameVer : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = "Version: " + Application.version;
    }
}
