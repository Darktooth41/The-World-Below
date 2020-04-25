using UnityEngine;
using System;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

	public Text AlphaText;
	// Declaring Upgrade Text Values
	public Text ManualUpgradeAmount;
	public Text ManualUpgradeCost;
	public Text AlphaUpgradeAmount;
	public Text AlphaUpgradeCost;
	public Text BetaUpgradeAmount;
	public Text BetaUpgradeCost;
	public Text GammaUpgradeAmount;
	public Text GammaUpgradeCost;
	public Text DeltaUpgradeAmount;
	public Text DeltaUpgradeCost;
	public Text EpsilonUpgradeAmount;
	public Text EpsilonUpgradeCost;
	public Text ZetaUpgradeAmount;
	public Text ZetaUpgradeCost;
	public Text EtaUpgradeAmount;
	public Text EtaUpgradeCost;
	public Text ThetaUpgradeAmount;
	public Text ThetaUpgradeCost;

	// Update is called once per frame
	void Update () {

		AlphaText.text = "Lifelines: " + CompAmount(Global.Instance.Alpha);
		// Update Upgrade Text UI
		ManualUpgradeAmount.text = CompAmount(Global.Instance.man_upgrade_level);
		ManualUpgradeCost.text = CompCost(Global.Instance.man_upgrade_cost);
		AlphaUpgradeAmount.text = CompAmount(Global.Instance.alpha_producer_upgrade_level);
		AlphaUpgradeCost.text = CompCost(Global.Instance.alpha_producer_upgrade_cost);
		BetaUpgradeAmount.text = CompAmount(Global.Instance.beta_producer_upgrade_level);
		BetaUpgradeCost.text = CompCost(Global.Instance.beta_producer_upgrade_cost);
		GammaUpgradeAmount.text = CompAmount(Global.Instance.gamma_producer_upgrade_level);
		GammaUpgradeCost.text = CompCost(Global.Instance.gamma_producer_upgrade_cost);
		DeltaUpgradeAmount.text = CompAmount(Global.Instance.delta_producer_upgrade_level);
		DeltaUpgradeCost.text = CompCost(Global.Instance.delta_producer_upgrade_cost);
		EpsilonUpgradeAmount.text = CompAmount(Global.Instance.epsilon_producer_upgrade_level);
		EpsilonUpgradeCost.text = CompCost(Global.Instance.epsilon_producer_upgrade_cost);
		ZetaUpgradeAmount.text = CompAmount(Global.Instance.zeta_producer_upgrade_level);
		ZetaUpgradeCost.text = CompCost(Global.Instance.zeta_producer_upgrade_cost);
		EtaUpgradeAmount.text = CompAmount(Global.Instance.eta_producer_upgrade_level);
		EtaUpgradeCost.text = CompCost(Global.Instance.eta_producer_upgrade_cost);
		ThetaUpgradeAmount.text = CompAmount(Global.Instance.theta_producer_upgrade_level);
		ThetaUpgradeCost.text = CompCost(Global.Instance.theta_producer_upgrade_cost);

	}

	public string CompAmount(double CreatorAmount)
	{
		var signgen = Math.Sign(CreatorAmount);
		CreatorAmount = Math.Abs(CreatorAmount);
		if (CreatorAmount >= 1000)
		{
			var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(CreatorAmount))));
			var mantissa = (CreatorAmount / System.Math.Pow(10, exponent));
			return mantissa.ToString("F2") + "e" + exponent.ToString();
		}
		else
			return CreatorAmount.ToString("F0");
	}

	// The previous method is the same and this one, but named differently. This is so I don't get confused using the same method for everything I want to compress.
	// Compress any COST to scientific value
	public string CompCost(double CreatorCost)
	{
		var signcost = Math.Sign(CreatorCost);
		CreatorCost = Math.Abs(CreatorCost);
		if (CreatorCost >= 1000)
		{
			var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(CreatorCost))));
			var mantissa = (CreatorCost / System.Math.Pow(10, exponent));
			return mantissa.ToString("F2") + "e" + exponent.ToString();
		}
		else
			return CreatorCost.ToString("F0");
	}
	public void Man_upgrade()
	{
		if (Global.Instance.Alpha >= Global.Instance.man_upgrade_cost)
		{
			Global.Instance.Alpha -= Global.Instance.man_upgrade_cost;
			Global.Instance.man_upgrade_cost = Math.Floor(Global.Instance.man_upgrade_cost * 1000);
			Global.Instance.man_upgrade_level++;
			Global.Instance.man_click *= 10;
		}
	}
	public void Alpha_upgrade()
	{
		if (Global.Instance.Alpha >= Global.Instance.alpha_producer_upgrade_cost)
		{
			Global.Instance.Alpha -= Global.Instance.alpha_producer_upgrade_cost;
			Global.Instance.alpha_producer_upgrade_cost = Math.Floor(Global.Instance.alpha_producer_upgrade_cost * 1000);
			Global.Instance.alpha_producer_upgrade_level++;
			Global.Instance.alpha_producer_upgrade_base *= 2;
		}
	}
	public void Beta_upgrade()
	{
		if (Global.Instance.Alpha >= Global.Instance.beta_producer_upgrade_cost)
		{
			Global.Instance.Alpha -= Global.Instance.beta_producer_upgrade_cost;
			Global.Instance.beta_producer_upgrade_cost = Math.Floor(Global.Instance.beta_producer_upgrade_cost * 1000);
			Global.Instance.beta_producer_upgrade_level++;
			Global.Instance.beta_producer_upgrade_base *= 2;
		}
	}
	public void Gamma_upgrade()
	{
		if (Global.Instance.Alpha >= Global.Instance.gamma_producer_upgrade_cost)
		{
			Global.Instance.Alpha -= Global.Instance.gamma_producer_upgrade_cost;
			Global.Instance.gamma_producer_upgrade_cost = Math.Floor(Global.Instance.gamma_producer_upgrade_cost * 1000);
			Global.Instance.gamma_producer_upgrade_level++;
			Global.Instance.gamma_producer_upgrade_base *= 2;
		}
	}
	public void Delta_upgrade()
	{
		if (Global.Instance.Alpha >= Global.Instance.delta_producer_upgrade_cost)
		{
			Global.Instance.Alpha -= Global.Instance.delta_producer_upgrade_cost;
			Global.Instance.delta_producer_upgrade_cost = Math.Floor(Global.Instance.delta_producer_upgrade_cost * 1000);
			Global.Instance.delta_producer_upgrade_level++;
			Global.Instance.delta_producer_upgrade_base *= 2;
		}
	}
	public void Epsilon_upgrade()
	{
		if (Global.Instance.Alpha >= Global.Instance.epsilon_producer_upgrade_cost)
		{
			Global.Instance.Alpha -= Global.Instance.epsilon_producer_upgrade_cost;
			Global.Instance.epsilon_producer_upgrade_cost = Math.Floor(Global.Instance.epsilon_producer_upgrade_cost * 1000);
			Global.Instance.epsilon_producer_upgrade_level++;
			Global.Instance.epsilon_producer_upgrade_base *= 2;
		}
	}
	public void Zeta_upgrade()
	{
		if (Global.Instance.Alpha >= Global.Instance.zeta_producer_upgrade_cost)
		{
			Global.Instance.Alpha -= Global.Instance.zeta_producer_upgrade_cost;
			Global.Instance.zeta_producer_upgrade_cost = Math.Floor(Global.Instance.zeta_producer_upgrade_cost * 1000);
			Global.Instance.zeta_producer_upgrade_level++;
			Global.Instance.zeta_producer_upgrade_base *= 2;
		}
	}
	public void Eta_upgrade()
	{
		if (Global.Instance.Alpha >= Global.Instance.eta_producer_upgrade_cost)
		{
			Global.Instance.Alpha -= Global.Instance.eta_producer_upgrade_cost;
			Global.Instance.eta_producer_upgrade_cost = Math.Floor(Global.Instance.eta_producer_upgrade_cost * 1000);
			Global.Instance.eta_producer_upgrade_level++;
			Global.Instance.eta_producer_upgrade_base *= 2;
		}
	}
	public void Theta_upgrade()
	{
		if (Global.Instance.Alpha >= Global.Instance.theta_producer_upgrade_cost)
		{
			Global.Instance.Alpha -= Global.Instance.theta_producer_upgrade_cost;
			Global.Instance.theta_producer_upgrade_cost = Math.Floor(Global.Instance.theta_producer_upgrade_cost * 1000);
			Global.Instance.theta_producer_upgrade_level++;
			Global.Instance.theta_producer_upgrade_base *= 2;
		}
	}
}
