using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour {

	public static Global Instance { get; private set; }

	// Global Producer Variables
	public double Number;
	public double man_click = 1;
	public double Alpha = 0;
	public double alpha_producer_amount = 0;
	public double alpha_producer_cost = 25;
	public double alpha_producer_upgrade_base = 1;
	public double beta_producer_amount = 0;
	public double beta_producer_cost = 1000;
	public double beta_producer_upgrade_base = 1;
	public double gamma_producer_amount = 0;
	public double gamma_producer_cost = 40000;
	public double gamma_producer_upgrade_base = 1;
	public double delta_producer_amount = 0;
	public double delta_producer_cost = 1600000;
	public double delta_producer_upgrade_base = 1;
	public double epsilon_producer_amount = 0;
	public double epsilon_producer_cost = 64000000;
	public double epsilon_producer_upgrade_base = 1;
	public double zeta_producer_amount = 0;
	public double zeta_producer_cost = 2560000000;
	public double zeta_producer_upgrade_base = 1;
	public double eta_producer_amount = 0;
	public double eta_producer_cost = 102400000000;
	public double eta_producer_upgrade_base = 1;
	public double theta_producer_amount = 0;
	public double theta_producer_cost = 4096000000000;
	public double theta_producer_upgrade_base = 1;

	// Declaring upgrade values
	public double man_upgrade_level = 0;
	public double man_upgrade_cost = 25;
	public double alpha_producer_upgrade_level = 0;
	public double alpha_producer_upgrade_cost = 25000;
	public double beta_producer_upgrade_level = 0;
	public double beta_producer_upgrade_cost = 1000000;
	public double gamma_producer_upgrade_level = 0;
	public double gamma_producer_upgrade_cost = 40000000;
	public double delta_producer_upgrade_level = 0;
	public double delta_producer_upgrade_cost = 1600000000;
	public double epsilon_producer_upgrade_level = 0;
	public double epsilon_producer_upgrade_cost = 64000000000;
	public double zeta_producer_upgrade_level = 0;
	public double zeta_producer_upgrade_cost = 2560000000000;
	public double eta_producer_upgrade_level = 0;
	public double eta_producer_upgrade_cost = 102400000000000;
	public double theta_producer_upgrade_level = 0;
	public double theta_producer_upgrade_cost = 4096000000000000;

	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
			Destroy(gameObject);
	}
}
