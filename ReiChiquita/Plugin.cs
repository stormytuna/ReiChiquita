using BepInEx;
using BepInEx.Logging;
using LethalLib;
using UnityEngine;

namespace ReiChiquita
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	[BepInDependency(Plugin.ModGUID)]
	public class ReiChiquitaBase : BaseUnityPlugin
	{
		public const string ModGUID = "stormytuna.ReiChiquita";
		public const string ModName = "ReiChiquita";
		public const string ModVersion = "1.0.0";

		public static ManualLogSource Log = BepInEx.Logging.Logger.CreateLogSource(ModGUID);
		public static ReiChiquitaBase Instance;
		public static AssetBundle CustomAssets;
	}
}
