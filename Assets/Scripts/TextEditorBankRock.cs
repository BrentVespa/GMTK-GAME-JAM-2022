using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEditorBankRock : MonoBehaviour
{
    public BankManager Keep;

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
        Bank bank = this.Keep.bank;
        ResourceTypes.Resource resource = ResourceTypes.Resource.Rock;
        UIText.GetComponent<TMPro.TextMeshProUGUI>().text = bank.getResource(resource).ToString();
        Invoke("TextUpdater", 1);
    }
}
