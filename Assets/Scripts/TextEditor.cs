using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEditorWood : MonoBehaviour
{
    public PlayerManager Player;

    public GameObject UIText;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("TextUpdater", 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TextUpdater()
    {
        Wallet wallet = this.Player.wallet;
        ResourceTypes.Resource resource = ResourceTypes.Resource.Wood;
        UIText.GetComponent<TMPro.TextMeshProUGUI>().text = wallet.getResource(resource).ToString();
        Invoke("TextUpdater", 1);
    }
}
