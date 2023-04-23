using UnityEngine;
using UnityEngine.UI;

public class ChangeToWater : MonoBehaviour
{
    public ScienceProjectScript scienceProjectScript;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        scienceProjectScript.material = "water";
    }
}
// when you press waterButton it runs this script which changes the value of variable 'material' of class 'scienceProjectScript' to 'water'