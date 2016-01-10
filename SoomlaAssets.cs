using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Soomla;

namespace Soomla.Store {

	public class SoomlaAssets : IStoreAssets {
		
		public int GetVersion() {
			return 1;
		}

		public VirtualCurrency[] GetCurrencies(){
			return new VirtualCurrency[]{};
		}

	    public VirtualGood[] GetGoods() {
			return new VirtualGood[] {NO_ADS_LTVG};
		}

		public VirtualCurrencyPack[] GetCurrencyPacks(){
			return new VirtualCurrencyPack[]{};
		}

		public VirtualCategory[] GetCategories(){
			return new VirtualCategory[]{};
		}

		public const string NO_ADS_LIFETIME_PRODUCT_ID = "no_ads";

		public static VirtualGood NO_ADS_LTVG = new LifetimeVG(
			"No Ads", 														// name
			"No More Ads! + 33 More Puzzles",								// description
			"No_Ads_Item_ID",														// item id
			new PurchaseWithMarket(NO_ADS_LIFETIME_PRODUCT_ID, 0.99)
		);	// the way this virtual good is purchased
		
	}

}
