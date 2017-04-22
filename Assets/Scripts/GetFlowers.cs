using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityEngine
{
	public class GetFlowers : MonoBehaviour
	{
		private static string blackOverlayColor = "#969696FF";
		private static string whiteOverlayColor = "#FFFFFFFF";

		private static int PRICE_BOMB = 1000;
		private static int PRICE_WALL = 2000;
		private static int PRICE_FREEZE = 4000;
		private static int PRICE_EXPLODE = 10000;

		#region Variable declaration
		private Button btnSUN;
		private Button btnSHOOTER;
		private Button btnBOMB;
		private Button btnWALL;
		private Button btnFREEZE;
		private Button btnEXPLODE;

		private Image imgSUN;
		private Image imgSHOOTER;
		private Image imgBOMB;
		private Image imgWALL;
		private Image imgFREEZE;
		private Image imgEXPLODE;
		#endregion

		void Start()
		{
			#region Variable init
			btnSUN = GameObject.Find("ownedBtnSUN").GetComponent<Button>();
			btnSHOOTER = GameObject.Find("ownedBtnSHOOTER").GetComponent<Button>();
			btnBOMB = GameObject.Find("ownedBtnBOMB").GetComponent<Button>();
			btnWALL = GameObject.Find("ownedBtnWALL").GetComponent<Button>();
			btnFREEZE = GameObject.Find("ownedBtnFREEZE").GetComponent<Button>();
			btnEXPLODE = GameObject.Find("ownedBtnEXPLODE").GetComponent<Button>();

			imgSUN = GameObject.Find("flowerSUN").GetComponent<Image>();
			imgSHOOTER = GameObject.Find("flowerPEASHOOTER").GetComponent<Image>();
			imgBOMB = GameObject.Find("flowerBOMB").GetComponent<Image>();
			imgWALL = GameObject.Find("flowerWALL").GetComponent<Image>();
			imgFREEZE = GameObject.Find("flowerFREEZE").GetComponent<Image>();
			imgEXPLODE = GameObject.Find("flowerEXPLODE").GetComponent<Image>();

			btnSUN.GetComponentInChildren<Text>().text = "OWNED";
			btnSHOOTER.GetComponentInChildren<Text>().text = "OWNED";

			#endregion
			btnBOMB.onClick.AddListener(onClickBOMB);
			btnWALL.onClick.AddListener(onClickWALL);
			btnFREEZE.onClick.AddListener(onClickFREEZE);
			btnEXPLODE.onClick.AddListener(onClickEXPLODE);
			setImgs();
		}
		
		private void setImgs()
		{
			setImgBomb();
			setImgWall();
			setImgFreeze();
			setImgExplode();
		}

		private void setImgBomb()
		{
			if (System.Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_BOMB)))
			{
				btnBOMB.GetComponentInChildren<Text>().text = "OWNED";
				imgBOMB.color = toColor(whiteOverlayColor);
			}
			else
			{
				btnBOMB.GetComponentInChildren<Text>().text = "UNLOCK";
				imgBOMB.color = toColor(blackOverlayColor);
			}
		}

		private void setImgWall()
		{
			if (System.Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_WALL)))
			{
				btnWALL.GetComponentInChildren<Text>().text = "OWNED";
				imgWALL.color = toColor(whiteOverlayColor);
			}
			else
			{
				btnWALL.GetComponentInChildren<Text>().text = "UNLOCK";
				imgWALL.color = toColor(blackOverlayColor);
			}
		}

		private void setImgFreeze()
		{
			if (System.Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_FREEZE)))
			{
				btnFREEZE.GetComponentInChildren<Text>().text = "OWNED";
				imgFREEZE.color = toColor(whiteOverlayColor);
			}
			else
			{
				btnFREEZE.GetComponentInChildren<Text>().text = "UNLOCK";
				imgFREEZE.color = toColor(blackOverlayColor);
			}
		}

		private void setImgExplode()
		{
			if (System.Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_EXPLODE)))
			{
				btnEXPLODE.GetComponentInChildren<Text>().text = "OWNED";
				imgEXPLODE.color = toColor(whiteOverlayColor);
			}
			else
			{
				btnEXPLODE.GetComponentInChildren<Text>().text = "UNLOCK";
				imgEXPLODE.color = toColor(blackOverlayColor);
			}
		}

		private void onClickBOMB()
		{
			if (!System.Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_BOMB)))
			{
				int bal = System.Int32.Parse(PlayerPrefs.GetString(HelperClass.PREF_BALANCE));
				if (bal - PRICE_BOMB >= 0)
				{
					Debug.Log("Bought bomb");
					Debug.Log("Price " + PRICE_BOMB);
					PlayerPrefs.SetString(HelperClass.PREF_BALANCE, (bal - PRICE_BOMB).ToString());
					PlayerPrefs.SetString(HelperClass.PREF_F_BOMB, "true");
					PlayerPrefs.Save();
					Debug.Log(PlayerPrefs.GetString(HelperClass.PREF_BALANCE));
					setImgBomb();
				}
			}
		}

		private void onClickWALL()
		{
			if (!System.Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_WALL)))
			{
				int bal = System.Int32.Parse(PlayerPrefs.GetString(HelperClass.PREF_BALANCE));
				if (bal - PRICE_WALL >= 0)
				{
					Debug.Log("Bought wall");
					Debug.Log("Price " + PRICE_WALL);
					PlayerPrefs.SetString(HelperClass.PREF_BALANCE, (bal - PRICE_WALL).ToString());
					PlayerPrefs.SetString(HelperClass.PREF_F_WALL, "true");
					PlayerPrefs.Save();
					Debug.Log(PlayerPrefs.GetString(HelperClass.PREF_BALANCE));
					setImgWall();
				}
			}
		}

		private void onClickFREEZE()
		{
			if (!System.Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_FREEZE)))
			{
				int bal = System.Int32.Parse(PlayerPrefs.GetString(HelperClass.PREF_BALANCE));
				if (bal - PRICE_FREEZE >= 0)
				{
					Debug.Log("Bought freeze");
					Debug.Log("Price " + PRICE_FREEZE);
					PlayerPrefs.SetString(HelperClass.PREF_BALANCE, (bal - PRICE_FREEZE).ToString());
					PlayerPrefs.SetString(HelperClass.PREF_F_FREEZE, "true");
					PlayerPrefs.Save();
					Debug.Log(PlayerPrefs.GetString(HelperClass.PREF_BALANCE));
					setImgFreeze();
				}
			}
		}

		private void onClickEXPLODE()
		{
			if (!System.Convert.ToBoolean(PlayerPrefs.GetString(HelperClass.PREF_F_EXPLODE)))
			{
				int bal = System.Int32.Parse(PlayerPrefs.GetString(HelperClass.PREF_BALANCE));
				if (bal - PRICE_EXPLODE >= 0)
				{
					Debug.Log("Bought explode");
					Debug.Log("Price " + PRICE_EXPLODE);
					PlayerPrefs.SetString(HelperClass.PREF_BALANCE, (bal - PRICE_EXPLODE).ToString());
					PlayerPrefs.SetString(HelperClass.PREF_F_EXPLODE, "true");
					PlayerPrefs.Save();
					Debug.Log(PlayerPrefs.GetString(HelperClass.PREF_BALANCE));
					setImgExplode();
				}
			}
		}

		public Color toColor(string hex)
		{
			hex = hex.Replace("#", "");
			byte a = 255;
			byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
			byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
			byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
			
			if (hex.Length == 8)
			{
				a = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
			}
			return new Color32(r, g, b, a);
		}
	}
}
