using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank {

	private int[] bank;

	public Bank() {
		this.bank = new int[sizeof(ResourceTypes.Resource)];
	}

	public void addResource(ResourceTypes.Resource type, int amount) {
		this.bank[(int)type] += amount;
		validateBank(type);
	}

	public void randomSubtractResource(ResourceTypes.Resource type) {
		this.bank[(int)type] -= Random.Range(1, 8);
	}

	public int getResource(ResourceTypes.Resource type) {
		return this.bank[(int)type];
	}

	public void validateBank(ResourceTypes.Resource type) {
		int resourceHeldCount = getResource(type);
		if (resourceHeldCount < 0) { //Negative resources in bank. Set to 0.
			this.bank[(int)type] = 0;
		}
	}

	public bool validatePurchase(ResourceTypes.Resource[] types, int[] costs) {
		bool haveEnough = true;
		for (int i = 0; i < types.Length; i++) {
			if (haveEnough && this.getResource(types[i]) < costs[i]) {
				haveEnough = false; break;
			}
		}
		if (haveEnough) {
			for (int i = 0; i < types.Length; i++) {
				this.addResource(types[i], -(costs[i]));
			}
		}
		Debug.Log(haveEnough);
		return haveEnough;
	}
}
