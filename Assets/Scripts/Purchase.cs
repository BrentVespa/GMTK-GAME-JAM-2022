using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchase : MonoBehaviour {

    public BankManager Keep;
    public PlayerManager Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            purchaseUpgrade();
        }
        else if (Input.GetKeyDown(KeyCode.Q)) {
            depositWallet();
		}
        else if (Input.GetKeyDown(KeyCode.W)) {
            Player.wallet.addResource(ResourceTypes.Resource.Rock, 25);
            Player.wallet.addResource(ResourceTypes.Resource.Wood, 25);
            Keep.bank.addResource(ResourceTypes.Resource.Rock, 250);
            Keep.bank.addResource(ResourceTypes.Resource.Wood, 250);
            Debug.Log("Added Resources"); //++++++++++++++++++++++
        }
    }

    public void purchaseUpgrade() {
        Bank bank = this.Keep.bank;
        Wallet wallet = this.Player.wallet;
        int numberOfElements = 2;
        int[] costs = new int[numberOfElements];
        ResourceTypes.Resource[] types = new ResourceTypes.Resource[numberOfElements];

        for (int i = 0; i < numberOfElements; i++) {
            costs[i] = 25 + (35 * wallet.getWalletTier());
            ResourceTypes.Resource currentResource = (ResourceTypes.Resource)System.Enum.ToObject(typeof(ResourceTypes.Resource), i);
            
            Debug.Log(currentResource); //++++++++++

            
            types[i] = currentResource;

            Debug.Log(bank.getResource(currentResource) + " number of " + currentResource); //
        }

        if (bank.validatePurchase(types, costs)) {
            wallet.increaseWalletTier();
            Debug.Log("Wallet Bought");
		}

	}
    public void depositWallet() { // Method to deposit all wallet into bank
        Bank bank = this.Keep.bank;
        Wallet wallet = this.Player.wallet;

        for (int i = 0; i < sizeof(ResourceTypes.Resource); i++) {
            ResourceTypes.Resource currentResource = (ResourceTypes.Resource)System.Enum.ToObject(typeof(ResourceTypes.Resource), i);

            Debug.Log(bank.getResource(currentResource) + " " + currentResource); //

            bank.addResource(currentResource, wallet.getResource(currentResource));
            wallet.clearResource(currentResource);

            Debug.Log(bank.getResource(currentResource) + " " + currentResource); //
		}
	}
}
