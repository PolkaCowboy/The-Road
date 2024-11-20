using RDR2;
using RDR2.Math;
using RDR2.Native;
using RDR2.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TheRoad {
	public class TheRoad : Script {

		private bool showRowStatus = false;
		private List<CheckPoint> _checkPoints = new List<CheckPoint>();
		private List<Blip> _blips = new List<Blip>();
		public TheRoad() {

			_checkPoints.Add(
				new CheckPoint() {
					Label = "Checkpoint 1",
					CheckPoints = new List<Vector3>() {
						new Vector3(-5945f, -3063, 0f),
						new Vector3(-5945f, -3179, 0f),
						new Vector3(-5945f, -3255, 0f),
						new Vector3(-5945f, -3510, 0f),
						new Vector3(-5945f, -3634, 0f),
						new Vector3(-5945f, -3704, 0f),
						new Vector3(-5945f, -3754, 0f),
					}
				}
			);
			_checkPoints.Add(
				new CheckPoint() {
					Label = "Checkpoint 2",
					CheckPoints = new List<Vector3>() {
						new Vector3(-4727, -2667, 0f),
						new Vector3(-4727, -2772, 0f),
						new Vector3(-4727, -3003, 0f),
						new Vector3(-4727, -3155, 0f),
						new Vector3(-4727, -3352, 0f),
						new Vector3(-4727, -3429, 0f),
						new Vector3(-4727, -3666, 0f),
						new Vector3(-4727, -3811, 0f),
					}
				}
			);
			_checkPoints.Add(
				new CheckPoint() {
					Label = "Checkpoint 3",
					CheckPoints = new List<Vector3>() {
						new Vector3(-3499, -2236, 0f),
						new Vector3(-3499, -2393, 0f),
						new Vector3(-3499, -2611, 0f),
						new Vector3(-3499, -2650, 0f),
						new Vector3(-3499, -3085, 0f),
					}
				}
			);
			_checkPoints.Add(
				new CheckPoint() {
					Label = "Checkpoint 4",
					CheckPoints = new List<Vector3>() {
						new Vector3(-2287, -2932, 0f),
						new Vector3(-2287, -2720, 0f),
						new Vector3(-2287, -2670, 0f),
						new Vector3(-2287, -2608, 0f),
						new Vector3(-2287, -2544, 0f),
						new Vector3(-2287, -2462, 0f),
						new Vector3(-2287, -2161, 0f),
						new Vector3(-2287, -1908, 0f),
						new Vector3(-2287, -1640, 0f),
						new Vector3(-2287, -1590, 0f),
						new Vector3(-2287, -1260, 0f),
						new Vector3(-2287, -574, 0f),
						new Vector3(-2287, -410, 0f),
						new Vector3(-2287, -318, 0f),
						new Vector3(-2287, -117, 0f),
						new Vector3(-2287, -50, 0f),
						new Vector3(-2287, 240, 0f),
						new Vector3(-2287, 499, 0f),
						new Vector3(-2287, 647, 0f),
						new Vector3(-2287, 786, 0f),
						new Vector3(-2287, 786, 0f),
					}
				}
			);
			_checkPoints.Add(
				new CheckPoint() {
					Label = "Checkpoint 5",
					CheckPoints = new List<Vector3>() {
						new Vector3(-1071, -1838, 0f),
						new Vector3(-1071, -1499, 0f),
						new Vector3(-1071, -1211, 0f),
						new Vector3(-1071, -1180, 0f),
						new Vector3(-1071, -685, 0f),
						new Vector3(-1071, -578, 0f),
						new Vector3(-1071, -457, 0f),
						new Vector3(-1071, -282, 0f),
						new Vector3(-1071, -110, 0f),
						new Vector3(-1071, -110, 0f),
						new Vector3(-1071, 15, 0f),
						new Vector3(-1071, 125, 0f),
						new Vector3(-1071, 361, 0f),
						new Vector3(-1071, 447, 0f),
						new Vector3(-1071, 849, 0f),
						new Vector3(-1071, 929, 0f),
						new Vector3(-1071, 1512, 0f),
					}
				}
			);
			_checkPoints.Add(
				new CheckPoint() {
					Label = "Checkpoint 6",
					CheckPoints = new List<Vector3>() {
						new Vector3(154, 1918, 0f),
						new Vector3(154, 1481, 0f),
						new Vector3(154, 1330, 0f),
						new Vector3(154, 1292, 0f),
						new Vector3(154, 1113, 0f),
						new Vector3(154, 1047, 0f),
						new Vector3(154, 890, 0f),
						new Vector3(154, 599, 0f),
						new Vector3(154, 526, 0f),
						new Vector3(154, 454, 0f),
						new Vector3(154, 69, 0f),
						new Vector3(154, -318, 0f),
						new Vector3(154, -481, 0f),
					}
				}
			);
			_checkPoints.Add(
				new CheckPoint() {
					Label = "Checkpoint 7",
					CheckPoints = new List<Vector3>() {
						new Vector3(1367, -2280, 0f),
						new Vector3(1367, -2059, 0f),
						new Vector3(1367, -1940, 0f),
						new Vector3(1367, -1778, 0f),
						new Vector3(1367, -1639, 0f),
						new Vector3(1367, -1487, 0f),
						new Vector3(1367, -1322, 0f),
						new Vector3(1367, -1088, 0f),
						new Vector3(1367, -860, 0f),
						new Vector3(1367, -804, 0f),
						new Vector3(1367, -312, 0f),
						new Vector3(1367, -231, 0f),
						new Vector3(1367, 180, 0f),
						new Vector3(1367, 307, 0f),
						new Vector3(1367, 466, 0f),
						new Vector3(1367, 1175, 0f),
						new Vector3(1367, 1319, 0f),
						new Vector3(1367, 1988, 0f),
					}
				}
			);
			_checkPoints.Add(
				new CheckPoint() {
					Label = "Checkpoint 8",
					CheckPoints = new List<Vector3>() {
						new Vector3(2592, -1425, 0f),
						new Vector3(2592, -1344, 0f),
						new Vector3(2592, -1261, 0f),
						new Vector3(2592, -1137, 0f),
						new Vector3(2592, -990, 0f),
						new Vector3(2592, -856, 0f),
						new Vector3(2592, -701, 0f),
						new Vector3(2592, -581, 0f),
						new Vector3(2592, -488, 0f),
						new Vector3(2592, -127, 0f),
						new Vector3(2592, 257, 0f),
						new Vector3(2592, 322, 0f),
						new Vector3(2592, 488, 0f),
						new Vector3(2592, 556, 0f),
						new Vector3(2592, 740, 0f),
						new Vector3(2592, 850, 0f),
						new Vector3(2592, 950, 0f),
						new Vector3(2592, 1321, 0f),
						new Vector3(2592, 1394, 0f),
						new Vector3(2592, 1594, 0f),
						new Vector3(2592, 1774, 0f),
						new Vector3(2592, 2228, 0f),

					}
				}
			);

			Tick += OnTick;
			KeyDown += OnKeyDown;
			Interval = 1;
		}

		private void OnTick(object sender, EventArgs evt) {
			if (showRowStatus) {
				Ped myPlayerPed = Game.Player.Character;
				var onRoad = PATHFIND.IS_POINT_ON_ROAD(myPlayerPed.Position, 0);
				
				TextElement textElement = new TextElement("", new PointF(152.0f, RDR2.UI.Screen.Height - 178.0f), 0.75f);
				if (onRoad) {
					textElement.Caption = "O";
					textElement.Color = Color.White;
				} else {
					textElement.Caption = "Ø";
					textElement.Color = Color.Red;
				}

				textElement.Draw();
			}
		}

		private void OnKeyDown(object sender, KeyEventArgs e) {
			// (Keyboard Only)
			if (e.KeyCode == Keys.F10) {
				showRowStatus = !showRowStatus;
			} else if (e.KeyCode == Keys.F11) {
				Random r = new Random();

				foreach (var dBlip in _blips) {
					dBlip.Delete();
				}

				var nextCps = _checkPoints.OrderBy(o => o.Distance()).FirstOrDefault(x => x.Distance() - 100 > 0);
				var nextBlip = nextCps.CheckPoints.ElementAt(r.Next(0, nextCps.CheckPoints.Count));
				var blip = World.CreateBlip(nextBlip, BlipType.BLIP_STYLE_DEBUG_GREEN);
				blip.Label = nextCps.Label;
				_blips.Add(blip);


				//foreach (var cp in _checkPoints) {
				//	foreach (var cp2 in cp.CheckPoints) {
				//		World.CreateBlip(cp2, BlipType.DestinationDark);
				//	}
				//}

			}
		}
	}

	public class CheckPoint {
		public string Label { get; set; }
		public List<Vector3> CheckPoints { get; set; }
		public float MinX() {
			return CheckPoints.Min(x => x.X);
		}
		public float Distance() {
			return MinX() - Game.Player.Character.Position.X;
		}
	}
}
