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
			if (HelperClass.FLOWER_BOMB)
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
			if (HelperClass.FLOWER_WALL)
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
			if (HelperClass.FLOWER_FREEZE)
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
			if (HelperClass.FLOWER_EXPLODE)
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
			HelperClass.instance.setBOMB(true);
			setImgBomb();
		}

		private void onClickWALL()
		{
			HelperClass.instance.setWALL(true);
			setImgWall();
		}

		private void onClickFREEZE()
		{
			HelperClass.instance.setFREEZE(true);
			setImgFreeze();
		}

		private void onClickEXPLODE()
		{
			HelperClass.instance.setEXPLODE(true);
			setImgExplode();
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
