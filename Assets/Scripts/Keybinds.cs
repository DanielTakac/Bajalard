using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keybinds : MonoBehaviour{

    public static readonly Dictionary<string, string> keybinds = new Dictionary<string, string>() {
        {"toggleCamera", "x"},
        {"restart", "r"},
        {"menu", "escape"},
        {"left", "a"},
        {"right", "d"},
        {"forward", "w"},
        {"back", "s"},
        {"up", "space"},
        {"down", "c"},
        {"rotateLeft", "q"},
        {"rotateRight", "e"}
    };

}
