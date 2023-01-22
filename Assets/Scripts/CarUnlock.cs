using UnityEngine;
using UnityEngine.UI;

public class CarUnlock : MonoBehaviour
{
    public int totalMetalCollected = 0;

    public bool carUnlocked;
    
    public Text targetText;
    public string newText = "";


    void Update()   
    {
      if (totalMetalCollected >= 10)
        {
            carUnlocked = true;
        }

        newText = totalMetalCollected.ToString();

        targetText.text = newText;
    }
}
