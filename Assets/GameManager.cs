using UnityEngine;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	// Delcaring Producer Text Values
	public Text AlphaText;
	public Text AlphaPerSec;
	public Text AlphaProdAmount;
	public Text AlphaProdSec;
	public Text AlphaProdCost;
	public Text BetaProdAmount;
	public Text BetaProdSec;
	public Text BetaProdCost;
	public Text GammaProdAmount;
	public Text GammaProdSec;
	public Text GammaProdCost;
	public Text DeltaProdAmount;
	public Text DeltaProdSec;
	public Text DeltaProdCost;
	public Text EpsilonProdAmount;
	public Text EpsilonProdSec;
	public Text EpsilonProdCost;
	public Text ZetaProdAmount;
	public Text ZetaProdSec;
	public Text ZetaProdCost;
	public Text EtaProdAmount;
	public Text EtaProdSec;
	public Text EtaProdCost;
	public Text ThetaProdAmount;
	public Text ThetaProdCost;

	// Update is called once per frame
	void Update()
	{
		// Update Producer Text UI
		AlphaText.text = "Lifelines: " + CompAmount(Global.Instance.Alpha);
		AlphaPerSec.text = CompAmount(Global.Instance.alpha_producer_amount * Global.Instance.alpha_producer_upgrade_base) + " /s";
		AlphaProdAmount.text = CompAmount(Global.Instance.alpha_producer_amount);
		AlphaProdSec.text = "+" + CompAmount(Global.Instance.beta_producer_amount * Global.Instance.beta_producer_upgrade_base) + " /s";
		AlphaProdCost.text = CompCost(Global.Instance.alpha_producer_cost);
		BetaProdAmount.text = CompAmount(Global.Instance.beta_producer_amount);
		BetaProdSec.text = "+" + CompAmount(Global.Instance.gamma_producer_amount * Global.Instance.gamma_producer_upgrade_base) + " /s";
		BetaProdCost.text = CompCost(Global.Instance.beta_producer_cost);
		GammaProdAmount.text = CompAmount(Global.Instance.gamma_producer_amount);
		GammaProdSec.text = "+" + CompAmount(Global.Instance.delta_producer_amount * Global.Instance.delta_producer_upgrade_base) + " /s";
		GammaProdCost.text = CompCost(Global.Instance.gamma_producer_cost);
		DeltaProdAmount.text = CompAmount(Global.Instance.delta_producer_amount);
		DeltaProdSec.text = "+" + CompAmount(Global.Instance.epsilon_producer_amount * Global.Instance.epsilon_producer_upgrade_base) + " /s";
		DeltaProdCost.text = CompCost(Global.Instance.delta_producer_cost);
		EpsilonProdAmount.text = CompAmount(Global.Instance.epsilon_producer_amount);
		EpsilonProdSec.text = "+" + CompAmount(Global.Instance.zeta_producer_amount * Global.Instance.zeta_producer_upgrade_base) + " /s";
		EpsilonProdCost.text = CompCost(Global.Instance.epsilon_producer_cost);
		ZetaProdAmount.text = CompAmount(Global.Instance.zeta_producer_amount);
		ZetaProdSec.text = "+" + CompAmount(Global.Instance.eta_producer_amount * Global.Instance.eta_producer_upgrade_base) + " /s";
		ZetaProdCost.text = CompCost(Global.Instance.zeta_producer_cost);
		EtaProdAmount.text = CompAmount(Global.Instance.eta_producer_amount);
		EtaProdSec.text = "+" + CompAmount(Global.Instance.theta_producer_amount * Global.Instance.theta_producer_upgrade_base) + " /s";
		EtaProdCost.text = CompCost(Global.Instance.eta_producer_cost);
		ThetaProdAmount.text = CompAmount(Global.Instance.theta_producer_amount);
		ThetaProdCost.text = CompCost(Global.Instance.theta_producer_cost);
		// Producers Produce Producers
		Global.Instance.Alpha += (Global.Instance.alpha_producer_amount * Global.Instance.alpha_producer_upgrade_base) * Time.deltaTime;
		Global.Instance.alpha_producer_amount += (Global.Instance.beta_producer_amount * Global.Instance.beta_producer_upgrade_base) * Time.deltaTime;
		Global.Instance.beta_producer_amount += (Global.Instance.gamma_producer_amount * Global.Instance.gamma_producer_upgrade_base) * Time.deltaTime;
		Global.Instance.gamma_producer_amount += (Global.Instance.delta_producer_amount * Global.Instance.delta_producer_upgrade_base) * Time.deltaTime;
		Global.Instance.delta_producer_amount += (Global.Instance.epsilon_producer_amount * Global.Instance.epsilon_producer_upgrade_base) * Time.deltaTime;
		Global.Instance.epsilon_producer_amount += (Global.Instance.zeta_producer_amount * Global.Instance.zeta_producer_upgrade_base) * Time.deltaTime;
		Global.Instance.zeta_producer_amount += (Global.Instance.eta_producer_amount * Global.Instance.eta_producer_upgrade_base) * Time.deltaTime;
		Global.Instance.eta_producer_amount += (Global.Instance.theta_producer_amount * Global.Instance.theta_producer_upgrade_base) * Time.deltaTime;
	}

	// Compress any AMOUNT to scientific value
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

	public void Manual_click()
	{
		Global.Instance.Alpha += Global.Instance.man_click;
	}
	public void Alpha_producer()
	{
		if (Global.Instance.Alpha >= Global.Instance.alpha_producer_cost)
		{
			Global.Instance.Alpha -= Global.Instance.alpha_producer_cost;
			Global.Instance.alpha_producer_cost = Math.Floor(Global.Instance.alpha_producer_cost * 1.07);
			Global.Instance.alpha_producer_amount++;
		}
	}
	public void Beta_producer()
	{
		if (Global.Instance.Alpha >= Global.Instance.beta_producer_cost)
		{
			Global.Instance.Alpha -= Global.Instance.beta_producer_cost;
			Global.Instance.beta_producer_cost = Math.Floor(Global.Instance.beta_producer_cost * 1.07);
			Global.Instance.beta_producer_amount++;
		}
	}
	public void Gamma_producer()
	{
		if (Global.Instance.Alpha >= Global.Instance.gamma_producer_cost)
		{
			Global.Instance.Alpha -= Global.Instance.gamma_producer_cost;
			Global.Instance.gamma_producer_cost = Math.Floor(Global.Instance.gamma_producer_cost * 1.07);
			Global.Instance.gamma_producer_amount++;
		}
	}
	public void Delta_producer()
	{
		if (Global.Instance.Alpha >= Global.Instance.delta_producer_cost)
		{
			Global.Instance.Alpha -= Global.Instance.delta_producer_cost;
			Global.Instance.delta_producer_cost = Math.Floor(Global.Instance.delta_producer_cost * 1.07);
			Global.Instance.delta_producer_amount++;
		}
	}
	public void Epsilon_producer()
	{
		if (Global.Instance.Alpha >= Global.Instance.epsilon_producer_cost)
		{
			Global.Instance.Alpha -= Global.Instance.epsilon_producer_cost;
			Global.Instance.epsilon_producer_cost = Math.Floor(Global.Instance.epsilon_producer_cost * 1.07);
			Global.Instance.epsilon_producer_amount++;
		}
	}
	public void Zeta_producer()
	{
		if (Global.Instance.Alpha >= Global.Instance.zeta_producer_cost)
		{
			Global.Instance.Alpha -= Global.Instance.zeta_producer_cost;
			Global.Instance.zeta_producer_cost = Math.Floor(Global.Instance.zeta_producer_cost * 1.07);
			Global.Instance.zeta_producer_amount++;
		}
	}
	public void Eta_producer()
	{
		if (Global.Instance.Alpha >= Global.Instance.eta_producer_cost)
		{
			Global.Instance.Alpha -= Global.Instance.eta_producer_cost;
			Global.Instance.eta_producer_cost = Math.Floor(Global.Instance.eta_producer_cost * 1.07);
			Global.Instance.eta_producer_amount++;
		}
	}
	public void Theta_producer()
	{
		if (Global.Instance.Alpha >= Global.Instance.theta_producer_cost)
		{
			Global.Instance.Alpha -= Global.Instance.theta_producer_cost;
			Global.Instance.theta_producer_cost = Math.Floor(Global.Instance.theta_producer_cost * 1.07);
			Global.Instance.theta_producer_amount++;
		}
	}
}
