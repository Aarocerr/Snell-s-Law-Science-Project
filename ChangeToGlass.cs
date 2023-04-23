using UnityEngine;
using UnityEngine.UI;

public class ChangeToGlass : MonoBehaviour
{
    public ScienceProjectScript scienceProjectScript;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        scienceProjectScript.material = "glass";
    }
}
// when you press glassButton it runs this script which changes the value of variable 'material' of class 'scienceProjectScript' to 'glass'