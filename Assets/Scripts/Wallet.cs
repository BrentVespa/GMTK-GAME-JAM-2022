using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet {

	private int[] wallet = new int[sizeof(ResourceTypes.Resource)];
	public Wallet() {

	}

	public ResourceTypes.Resource getResource(ResourceTypes.Resource type) {
		return type;
	}
	public void addResource(ResourceTypes.Resource type) {
		this.wallet[(int)type] += 10;
	}
}
