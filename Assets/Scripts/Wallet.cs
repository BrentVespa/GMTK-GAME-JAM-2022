using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet {

	private int[] wallet;
	public Wallet() {
		//Debug.Log("Wallet Created");
		wallet = new int[sizeof(ResourceTypes.Resource)];
	}

	public ResourceTypes.Resource getResourceType(ResourceTypes.Resource type) {
		return type;
	}
	public void addResource(ResourceTypes.Resource type) {
		this.wallet[(int)type] += 10;
	}

	public int getResource(ResourceTypes.Resource type) {
		Debug.Log(getResourceType(type) + " " + this.wallet[(int)type]);
		return this.wallet[(int)type];
	}
}
